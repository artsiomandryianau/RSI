using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;



namespace WcfServiceLibrary4
{

   [ServiceContract]
    public  interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void ReturnFindResult(string result);
    }
}
