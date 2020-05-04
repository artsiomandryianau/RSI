using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary4;


namespace WcfServiceHost
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:60002/");
            ServiceHost mojHost = new ServiceHost(typeof(Service1), baseAddress);
             BasicHttpBinding b = new BasicHttpBinding();

            Uri baseAddress2 = new Uri("http://localhost:50002/");
            ServiceHost mojHost2 = new ServiceHost(typeof(FindFile), baseAddress2);
            WSDualHttpBinding b2 = new WSDualHttpBinding();
            b.TransferMode = TransferMode.Streamed;
            b.MaxReceivedMessageSize = 99999999;
            b.MaxBufferSize = 8192;
            b2.MaxReceivedMessageSize = 99999999;
            
            try
            {
                mojHost2.AddServiceEndpoint(typeof(IFindFile), b2, "ICallbackFile");
                ServiceEndpoint endpoint1 = mojHost.AddServiceEndpoint(typeof(IService1), b, baseAddress);
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                mojHost.Description.Behaviors.Add(smb);
                var serviceMetadataBehavior = new ServiceMetadataBehavior { HttpGetEnabled = true };
                mojHost2.Description.Behaviors.Add(serviceMetadataBehavior);
                mojHost.Open();
                mojHost2.Open();
                Console.WriteLine("Server started. Stream is up.");
                Console.WriteLine("Press <ENTER> to finish!\n");
                Console.ReadLine();
                mojHost.Close();
                mojHost2.Close();
                Console.WriteLine("Finished");
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Exception: {0}", ce.Message);
                mojHost.Abort();
            }
        }
    }
}
