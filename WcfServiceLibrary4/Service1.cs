using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WcfServiceLibrary4
{

    public class Service1 : IService1
    {
       public static List<ResponseFileMessage> fileList = new List<ResponseFileMessage>();

        public ResponseFileMessage DownloadFile(RequestFileMessage request)
        {

            ResponseFileMessage wynik = new ResponseFileMessage();
            string nazwa = ".\\" + request.nazwa1;
            Console.WriteLine(nazwa);
            FileStream myFile;
            Console.WriteLine("-->wywołano downloadFile");
            string filePath = Path.Combine(System.Environment.CurrentDirectory, nazwa);
            try
            {
                myFile = File.OpenRead(filePath);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Wyjątek otwarcia pliku {filePath} :");
                Console.WriteLine(e.ToString());
                throw e;
            }
            wynik.nazwa2 = request.nazwa1;
            wynik.description = fileList.Find(x => x.nazwa2.Contains(wynik.nazwa2)) != null ? fileList.Find(x => x.nazwa2.Contains(wynik.nazwa2)).description : "brak opisu";
            wynik.rozmiar = myFile.Length;
            wynik.dane = myFile;
            return wynik;
        }
        
        public Stream GetStream(string nazwa)
        {
            FileStream myFile;
            Console.WriteLine("-->wywołano getStream");
            string filePath = Path.Combine(Environment.CurrentDirectory, ".\\image.jpg");
            try
            {
                myFile = File.OpenRead(filePath);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Wyjątek otwarcia pliku {filePath} :");
                Console.WriteLine(e.ToString());
                throw e;
            }
            return myFile;
        }
        public void UploadFile(ResponseFilePathMessage responseFile)
        {

            ResponseFileMessage wynik = new ResponseFileMessage();
            FileStream myFile;
            Console.WriteLine("-->wywołano openFile");
            string filePath = Path.Combine(responseFile.path, responseFile.name);
            try
            {
                myFile = File.OpenRead(filePath);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Wyjątek otwarcia pliku {filePath} :");
                Console.WriteLine(e.ToString());
                throw e;
            }
            wynik.nazwa2 = responseFile.name;
            wynik.rozmiar = myFile.Length;
            wynik.description = responseFile.description;
            wynik.dane = myFile;
            fileList.Add(wynik);
            Console.WriteLine(fileList.Count);
            string filePath2 = Path.Combine(Environment.CurrentDirectory, responseFile.name);
            SaveFile(wynik.dane, filePath2);
        }

        public void UploadFile2(RequestPathMessage requestPath)
        {
            string filePath2 = Path.Combine(System.Environment.CurrentDirectory, requestPath.name);
            ResponseFileMessage response = new ResponseFileMessage();
            response.nazwa2 = requestPath.name;
            response.description = requestPath.descriptionFile;
            response.dane = requestPath.stream;

            fileList.Add(response);
            SaveFile(requestPath.stream, filePath2);
        }
        
        static void SaveFile(Stream instream, string filePath)
        {
            const int bufferLength = 8192;
            int bytecount = 0;
            int counter = 0;

            byte[] buffer = new byte[bufferLength];
            Console.WriteLine("-->Zapiuje plik {0}", filePath);
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
            Console.WriteLine("Plik {0} zapisany", filePath);
        }

        public string ShowFile()
        {
            return fileList.Aggregate("", (current, f) => current + (f.nazwa2 + " opis: " + f.description + " rozmiar: " + f.rozmiar + "\n"));
        }

        public List<string> GetFilesList()
        {
            List<string> output = new List<string>();

            foreach(var item in fileList)
            {
                output.Add(item.nazwa2 + "," + item.description + ","  + item.rozmiar);
            }

            return output;
        }

        public string GetFileLocationOnServer(string fileName)
        {
            return Environment.CurrentDirectory +@"\"+ fileName;
        }

        public long GetFileLenght(string filename)
        {
            return fileList.Single(x => (x.nazwa2 == filename)).rozmiar;
        }
    }
  
}
