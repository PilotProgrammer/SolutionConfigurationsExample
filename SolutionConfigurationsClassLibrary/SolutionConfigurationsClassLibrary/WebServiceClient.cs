using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConfigurationsClassLibrary
{
    public class WebServiceClient
    {
        public string sendMessage(string messageToSend)
        {
            string returnStatus = null;

            if (string.IsNullOrEmpty(messageToSend) == true)
                throw new Exception("Can't send an empty message. Sorry 'bout that!");

#if DEBUG
            returnStatus = "Following message sent to TEST web service: " + messageToSend;
#else
            returnStatus = "Following message sent to PROD web service: " + messageToSend;
#endif
            return returnStatus;
        }
    }
}
