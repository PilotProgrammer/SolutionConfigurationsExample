using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionConfigurationsClassLibrary;

namespace SolutionConfigurationsClassLibraryClient
{
    public class ExternalDataAccessSettings : IExternalDataAccessSettings
    {
        public string DatabaseName
        {
            get
            { return "CONNECTION_STRING_OVERRIDE"; }
        }

        public string WebServiceUrl
        {
            get
            { return "URL_OVERRIDE"; }
        }
    }
}
