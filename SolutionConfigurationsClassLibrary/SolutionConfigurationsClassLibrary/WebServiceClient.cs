using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConfigurationsClassLibrary
{
    public class WebServiceClient
    {
        protected string WebServiceUrl;

        public WebServiceClient(IExternalDataAccessSettings settings)
        {
            this.WebServiceUrl = settings.GetWebServiceUrl();
        }

        public void SendMessage(string messageToSend)
        {
            if (string.IsNullOrEmpty(messageToSend) == true)
                throw new Exception("Can't send an empty message. Sorry 'bout that!");

            Console.WriteLine("Following message sent to " + this.WebServiceUrl + " web service: " + messageToSend);
        }
    }
}
