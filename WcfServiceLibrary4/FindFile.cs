using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace WcfServiceLibrary4
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
   public class FindFile: IFindFile
    {
        List<ResponseFileMessage> fileList = Service1.fileList;
        string resultFileFind;
        ICallback callback = null;


        public FindFile()
        {
            callback = OperationContext.Current.GetCallbackChannel<ICallback>();
        }


        void IFindFile.FindFile(string fileName)
        {
            Console.WriteLine("...wywołano znajdz plik:", fileName);
            Thread.Sleep(3000);
            ResponseFileMessage response = fileList.Find(x => x.nazwa2.Contains(fileName));
            if (response != null) {
                resultFileFind = "Znleziono plik: " + response.nazwa2 + " " + response.description + " rozmiar pliku:" + response.rozmiar;
            } else
                resultFileFind = "Nie znaleziono pliku";
            callback.ReturnFindResult(resultFileFind);
        }
    }
}
