namespace WindowsFormsClient
{
    partial class FormPhotos
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.buttonDownloadPhoto = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhotoName = new System.Windows.Forms.TextBox();
            this.textBoxPhotoDescr = new System.Windows.Forms.TextBox();
            this.textBoxPhotoSize = new System.Windows.Forms.TextBox();
            this.buttonUploadPhoto = new System.Windows.Forms.Button();
            this.textBoxFileLocation = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxFileNameSearcher = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textBoxFileDescr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.listView = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
         

            this.buttonDownloadPhoto.Location = new System.Drawing.Point(329, 204);
            this.buttonDownloadPhoto.Name = "buttonDownloadPhoto";
            this.buttonDownloadPhoto.Size = new System.Drawing.Size(233, 136);
            this.buttonDownloadPhoto.TabIndex = 1;
            this.buttonDownloadPhoto.Text = "Download";
            this.buttonDownloadPhoto.UseVisualStyleBackColor = true;
            this.buttonDownloadPhoto.Click += new System.EventHandler(this.buttonDownloadPhoto_Click);
          

            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(13, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 319);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Size:";
            
            //----------------------------------------
            this.textBoxPhotoName.Location = new System.Drawing.Point(329, 43);
            this.textBoxPhotoName.Name = "textBoxPhotoName";
            this.textBoxPhotoName.Size = new System.Drawing.Size(233, 20);
            this.textBoxPhotoName.TabIndex = 6;
            

            this.textBoxPhotoDescr.Location = new System.Drawing.Point(329, 95);
            this.textBoxPhotoDescr.Name = "textBoxPhotoDescr";
            this.textBoxPhotoDescr.Size = new System.Drawing.Size(233, 20);
            this.textBoxPhotoDescr.TabIndex = 7;
            //----------------------------------------

            this.textBoxPhotoSize.Location = new System.Drawing.Point(329, 156);
            this.textBoxPhotoSize.Name = "textBoxPhotoSize";
            this.textBoxPhotoSize.Size = new System.Drawing.Size(233, 20);
            this.textBoxPhotoSize.TabIndex = 8;
            //----------------------------------------

            this.buttonUploadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUploadPhoto.Location = new System.Drawing.Point(203, 455);
            this.buttonUploadPhoto.Name = "buttonUploadPhoto";
            this.buttonUploadPhoto.Size = new System.Drawing.Size(110, 63);
            this.buttonUploadPhoto.TabIndex = 9;
            this.buttonUploadPhoto.Text = "Add picture";
            this.buttonUploadPhoto.UseVisualStyleBackColor = true;
            this.buttonUploadPhoto.Click += new System.EventHandler(this.buttonUploadPhoto_Click);
            //----------------------------------------
            
            this.textBoxFileLocation.Location = new System.Drawing.Point(12, 383);
            this.textBoxFileLocation.Name = "textBoxFileLocation";
            this.textBoxFileLocation.Size = new System.Drawing.Size(177, 20);
            this.textBoxFileLocation.TabIndex = 10;
            //----------------------------------------


            this.openFileDialog.FileName = "openFileDialog1";
            //----------------------------------------

            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(329, 365);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(233, 23);
            this.progressBar.TabIndex = 12;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);

            //----------------------------------------
            this.textBoxFileNameSearcher.Location = new System.Drawing.Point(626, 538);
            this.textBoxFileNameSearcher.Name = "textBoxFileNameSearcher";
            this.textBoxFileNameSearcher.Size = new System.Drawing.Size(225, 20);
            this.textBoxFileNameSearcher.TabIndex = 13;
            //----------------------------------------

            this.buttonSearch.Location = new System.Drawing.Point(875, 538);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(82, 23);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Find";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            //----------------------------------------

            this.buttonSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSelectFile.Location = new System.Drawing.Point(203, 383);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(110, 26);
            this.buttonSelectFile.TabIndex = 16;
            this.buttonSelectFile.Text = "Chose the file";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            //----------------------------------------
            
            this.textBoxFileDescr.Location = new System.Drawing.Point(15, 498);
            this.textBoxFileDescr.Name = "textBoxFileDescr";
            this.textBoxFileDescr.Size = new System.Drawing.Size(174, 20);
            this.textBoxFileDescr.TabIndex = 20;
            //----------------------------------------

            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Description:";
            //----------------------------------------

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Path";
            //----------------------------------------

            this.textBoxFileName.Enabled = false;
            this.textBoxFileName.Location = new System.Drawing.Point(15, 442);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(174, 20);
            this.textBoxFileName.TabIndex = 19;
            //----------------------------------------

            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(10, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name:";
            //----------------------------------------

            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            //----------------------------------------

            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnDescr,
            this.columnSize});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(626, 21);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(331, 497);
            this.listView.TabIndex = 15;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            //----------------------------------------

            this.columnName.Text = "Name";
            this.columnName.Width = 84;
            //------------------------------------ 
       
            this.columnDescr.Text = "Desc";
            this.columnDescr.Width = 76;
            //----------------------------------------
            
            this.columnSize.Text = "Sixe";
            //----------------------------------------

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 573);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFileDescr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFileNameSearcher);
            this.Controls.Add(this.textBoxFileLocation);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxPhotoSize);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.textBoxPhotoDescr);
            this.Controls.Add(this.buttonUploadPhoto);
            this.Controls.Add(this.textBoxPhotoName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonDownloadPhoto);
            this.Name = "FormPhotos";
            this.Text = "Photos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDownloadPhoto;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPhotoName;
        private System.Windows.Forms.TextBox textBoxPhotoDescr;
        private System.Windows.Forms.TextBox textBoxPhotoSize;
        private System.Windows.Forms.Button buttonUploadPhoto;
        private System.Windows.Forms.TextBox textBoxFileLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBoxFileNameSearcher;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TextBox textBoxFileDescr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDescr;
        private System.Windows.Forms.ColumnHeader columnSize;
    }
}

