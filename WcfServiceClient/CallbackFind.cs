using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceClient.ServiceReference2;



namespace WcfServiceClient
{
    class CallbackFind : IFindFileCallback
    {
        /// <summary>
        /// Metoda wyświetlająca wynik wyszukiwania obrazu
        /// </summary>
        /// <param name="result">wynik wyszukiwania(String)</param>
        public void ReturnFindResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
