using System;
using System.ComponentModel;
using System.IO;
using System.ServiceModel;
using System.Windows.Forms;
using WindowsFormsClient.ServiceReference1;
using WindowsFormsClient.ServiceReference2;
using WcfServiceClient;
using System.Threading;


namespace WindowsFormsClient
{

    public partial class FormPhotos : Form
    {
        Service1Client client = new Service1Client();
        static CallbackFind mojCallbackHandler = new CallbackFind();
        static InstanceContext instanceContext = new InstanceContext(mojCallbackHandler);
        FindFileClient client2 = new FindFileClient(instanceContext);

        private bool OperationSuccess = true;
        string outputLocation = Environment.CurrentDirectory;

        public FormPhotos()
        {
            InitializeComponent();
        }

        private void RebaseListView()
        {
            var startupList = client.GetFilesList();

            listView.Items.Clear();

            foreach (var file in startupList)
            {
                var props = file.Split(',');
                ListViewItem item = new ListViewItem(props[0]);
                item.SubItems.Add(props[1]);
                item.SubItems.Add(props[2]);

                listView.Items.Add(item);
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            RebaseListView();
            listView.Refresh();
        }
       
        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            if (textBoxFileLocation.Text != "" && textBoxFileDescr.Text != "")
            {
                try
                {
                    client.UploadFile(textBoxFileDescr.Text, textBoxFileName.Text, textBoxFileLocation.Text);
                    MessageBox.Show("Uploaded");
                    RebaseListView();
                    listView.Refresh();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Smth went wrong" + exception);
                }
            }
            else
            {
                MessageBox.Show("Wrong download params");
            }
        }
     
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxFileNameSearcher.Text != "")
            {
                client2.FindFile(textBoxFileNameSearcher.Text);
            }
            else
            {
                MessageBox.Show("Enter find params!");
            }
        }
      
        private void buttonDownloadPhoto_Click(object sender, EventArgs e)
        {
            if (textBoxPhotoName.Text != "")
            {
                saveFileDialog.Title = "Choose saving file localization";
                saveFileDialog.Filter = "JPG Image| *.jpg";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    outputLocation = saveFileDialog.FileName;
                }
                else
                {
                    OperationSuccess = false;
                    MessageBox.Show("Invalid or empty filename!");
                }

                try
                {

                    progressBar.Maximum = 100;
                    progressBar.Step = 1;
                    progressBar.Value = 0;

                    string name1 = textBoxPhotoName.Text;
                    Stream fs1 = null;
                    long size1;
                    string n1;
                    name1 = client.DownloadFile(name1, out n1, out size1, out fs1);
                    SaveFile(fs1, outputLocation);
                }
                catch (Exception exception)
                {
                    OperationSuccess = false;
                    MessageBox.Show("Not downloaded" + exception);
                }
            }
            else
            {
                MessageBox.Show("Chose file to download!");
            }
        }
        
        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg";
            openFileDialog.Title = "Select an image file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFileLocation.Text = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                textBoxFileName.Text = openFileDialog.SafeFileName;
            }
        }
       
        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            textBoxPhotoName.Text = e.Item.SubItems[0].Text;
            textBoxPhotoDescr.Text = e.Item.SubItems[1].Text;
            textBoxPhotoSize.Text = e.Item.SubItems[2].Text;

            pictureBox.ImageLocation = client.GetFileLocationOnServer(textBoxPhotoName.Text);
        }
      
        private void SaveFile(System.IO.Stream instream, string filePath)
        {
            const int bufferLength = 8192;
            int bytecount = 0;
            int counter = 0;

            byte[] buffer = new byte[bufferLength];
            Console.WriteLine("-->Saving file{0}", filePath);
            FileStream outstream = File.Open(filePath, FileMode.Create, FileAccess.Write);

            while ((counter = instream.Read(buffer, 0, bufferLength)) > 0)
            {
                outstream.Write(buffer, 0, counter);
                Console.Write(".{0}", counter);
                bytecount += counter;
            }
            Console.WriteLine();
            Console.WriteLine("Saved {0} bytes", bytecount);
            outstream.Close();
            instream.Close();
            Console.WriteLine();
            Console.WriteLine("-->File {0} saved", filePath);
            backgroundWorker.RunWorkerAsync();
        }
        
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            
            for(int i=0; i<100; i++)
            {   
                backgroundWorker.ReportProgress(i+1);
                Thread.Sleep(500);
            }
                

        }
        
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
    
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (OperationSuccess)
            {
                MessageBox.Show("Downloaded");
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
