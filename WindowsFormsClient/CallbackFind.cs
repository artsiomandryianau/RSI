using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsClient.ServiceReference2;



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
            MessageBox.Show(result);
        }
    }
}
