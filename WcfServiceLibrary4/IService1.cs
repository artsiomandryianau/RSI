using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;



namespace WcfServiceLibrary4
{
    /// <summary>

    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Stream GetStream(string nazwa);

        [OperationContract]
        ResponseFileMessage DownloadFile(RequestFileMessage request);

        [OperationContract]
        void UploadFile(ResponseFilePathMessage responseFile);

        [OperationContract]
        void UploadFile2(RequestPathMessage requestPath);

        [OperationContract]
        string ShowFile();

        [OperationContract]
        List<string> GetFilesList();

        [OperationContract]
        string GetFileLocationOnServer(string fileName);

        [OperationContract]
        long GetFileLenght(string filename);
    }


    [MessageContract]
    public class RequestPathMessage
    {
        [MessageHeader]
        public string name;
        [MessageHeader]
        public string descriptionFile;
        [MessageBodyMember]
        public Stream stream;
    }

    [MessageContract]
    public class RequestFileMessage
    {
        [MessageBodyMember]
        public string nazwa1;

    }

    [MessageContract]
    public class ResponseFilePathMessage
    {
        [MessageHeader]
        public string name;
        [MessageHeader]
        public string description;
        [MessageBodyMember]
        public string path;
    }

    [MessageContract]
    public class ResponseFileMessage
    {

        [MessageHeader]
        public long rozmiar;
        [MessageHeader]
        public string description;
        [MessageHeader]
        public string nazwa2;
        [MessageBodyMember]
        public Stream dane;
    }
}
