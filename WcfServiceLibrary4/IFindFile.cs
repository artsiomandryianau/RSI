using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace WcfServiceLibrary4
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ICallback))]
   public interface IFindFile
    {

        [OperationContract(IsOneWay = true)]
        void FindFile(string fileName);
    }
}
