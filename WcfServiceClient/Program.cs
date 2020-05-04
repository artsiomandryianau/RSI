using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WcfServiceClient.ServiceReference1;
using WcfServiceClient.ServiceReference2;



namespace WcfServiceClient
{
    /// <summary>
    /// Klasa klienta
    /// </summary>
    class Program
    {/// <summary>
    /// Metoda main obsługuje wybrane usłygi klienta
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
           // Console.WriteLine("\nKLIENT2:");
            CallbackFind mojCallbackHandler = new CallbackFind();
            InstanceContext instanceContext = new InstanceContext(mojCallbackHandler);
            FindFileClient client2 = new FindFileClient(instanceContext);

            Console.WriteLine("podaj nazwe szukanego pliku");
            string nameFil = Console.ReadLine();
            Console.WriteLine("..wywołuje wyszukiwanie({0})...", nameFil);
            client2.FindFile(nameFil);

            Console.WriteLine("..,......");
            Thread.Sleep(10);


            Console.WriteLine("..wywołuje wyszukiwanie({0})...", "image.png");
            client2.FindFile("image.png");

            Console.WriteLine("..,......");

          

            Thread.Sleep(5000);

            Console.WriteLine("KONIEC KLIENT2");

            Service1Client client = new Service1Client();
      
            bool condition = true;
            int option;

            showCommands();
            
                        try
                        {

                            while (condition)
                            {
                                option = Int32.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1: //wyświetlenie menu
                                        {
                                            showCommands();
                                            break;
                                        }
                                    case 2: //dodawanie obrazu
                                        {
                                            Console.WriteLine("upload");
                                            Console.WriteLine("podaj ścieżke pliku");
                                            string path = Console.ReadLine();
                                            Console.WriteLine("podaj nazwe pliku");
                                            string fileName = Console.ReadLine();
                                            Console.WriteLine("podaj opis pliku");
                                            string fileDescription = Console.ReadLine();
                                            //FileStream fileStream= OpenFile(path, fileName);//ok
                                            //client.UploadFile2(fileDescription, fileName, fileStream);//błą
                                           client.UploadFile(fileDescription,fileName,path);

                                            break;
                                        }
                                    case 3: // pobieranie obrazu
                                        {
                                            Console.WriteLine("Download");
                                            Console.WriteLine("Podaj nazwe pliku do pobrania: ");
                                            string name1 = Console.ReadLine();
                                            Stream fs1 = null;
                                            long size1;
                                            string n1;
                                            name1 = client.DownloadFile(name1, out n1, out size1, out fs1);
                                            string filePath1 = Path.Combine(System.Environment.CurrentDirectory, n1);
                                            SaveFile(fs1, filePath1);
                                            Console.WriteLine("Pobrano plik" + n1);
                                            Console.WriteLine("opis: {0}, rozmiar: {1}", name1, size1);

                                            break;
                                        }
                                    case 4: // wyświetlenie wszystkich dostępnych plików
                                        {
                                            Console.WriteLine("Show File");
                                            Console.WriteLine(client.ShowFile());
                                            break;
                                        }
                                    case 5: // sprawdzenie czy istnieje wybrany plik na serwerze
                                        {
                                Console.WriteLine("podaj nazwe szukanego pliku");
                                string nameFile = Console.ReadLine();
                                Console.WriteLine("..wywołuje wyszukiwanie({0})...", nameFile);
                                client2.FindFile(nameFile);

                                Console.WriteLine("..,......");

                                Thread.Sleep(5000);
                               
                                Console.WriteLine("KONIEC KLIENT2");


                                break;
                                        }
                                    case 6://zamknięcie clienta
                                        {
                                            condition = false;
                                            break;
                                        }
                                    default:
                                        {
                                            showCommands();
                                            break;
                                        }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Podano błędny parametr!! "+e.ToString());

                        }
            client.Close();
            client2.Close();
            Console.WriteLine();
            Console.WriteLine("Nacisnij <ENTER> aby zakończyć");
            Console.ReadLine();
        }
        /// <summary>
        /// Metoda zapisuje plik w domyślnym folderze
        /// </summary>
        /// <param name="instream">plik który chcemy zapisać</param>
        /// <param name="filePath">ścieżka pliku który chcemy zapisać</param>
        static void SaveFile(System.IO.Stream instream, string filePath)
        {
            const int bufferLength = 8192;
            int bytecount = 0;
            int counter = 0;

            byte[] buffer = new byte[bufferLength];
            Console.WriteLine("-->Zapiuje plik{0}", filePath);
            FileStream outstream = File.Open(filePath, FileMode.Create, FileAccess.Write);

            while ((counter = instream.Read(buffer, 0, bufferLength)) > 0)
            {
                outstream.Write(buffer, 0, counter);
                Console.Write(".{0}", counter);
                bytecount += counter;
            }
            Console.WriteLine();
            Console.WriteLine("Zapisano {0} bajtów", bytecount);
            outstream.Close();
            instream.Close();
            Console.WriteLine();
            Console.WriteLine("-->Plik {0} zapisany", filePath);
        }
        /// <summary>
        /// Metoda która otwiera plik i zapisujego jako Strumień
        /// </summary>
        /// <param name="path">ścieżka do pliku w jakim się znajduje</param>
        /// <param name="name">nazwa pliku</param>
        /// <returns>zwraca plik(Stream)</returns>
        static FileStream OpenFile(string path, string name)
        {
            FileStream myFile;
            Console.WriteLine("-->wywołano openFile");
            string filePath = Path.Combine(path, name);
            try
            {
                myFile = File.OpenRead(filePath);
            }
            catch (IOException e)
            {
                Console.WriteLine(String.Format("Wyjątek otwarcia pliku {0} :", filePath));
                Console.WriteLine(e.ToString());
                throw e;
            }
            return myFile;
        }
        /// <summary>
        /// Metoda wyświetla dostępne usługi
        /// </summary>
        public static void showCommands()
        {
            Console.WriteLine("***************Menu**********************");
            Console.WriteLine("1: Wyświetl menu");
            Console.WriteLine("2: Dodaj obraz");
            Console.WriteLine("3: Pobierz obraz");
            Console.WriteLine("4: Wyświetl dostępne obrazy");
            Console.WriteLine("5: Spradz czy istnieje dany obraz");;
            Console.WriteLine("6: Zamknij program");
            Console.WriteLine("\nWybierz numer i zatwierdź klawiszem ENTER");
            Console.WriteLine("*****************************************");
        }
    }
}
