using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConfigurationsClassLibrary
{
    public class WebServiceClient
    {
        protected string webServiceUrl;

        public WebServiceClient(IExternalDataAccessSettings settings)
        {
            webServiceUrl = settings.getWebServiceUrl();
        }

        public void sendMessage(string messageToSend)
        {
            if (string.IsNullOrEmpty(messageToSend) == true)
                throw new Exception("Can't send an empty message. Sorry 'bout that!");

            Console.WriteLine("Following message sent to " + this.webServiceUrl + " web service: " + messageToSend);
        }
    }
}
