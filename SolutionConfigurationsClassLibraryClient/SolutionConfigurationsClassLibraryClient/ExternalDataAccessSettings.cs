using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionConfigurationsClassLibrary;
using System.Configuration;

namespace SolutionConfigurationsClassLibraryClient
{
    public class ExternalDataAccessSettings : IExternalDataAccessSettings
    {
        public string getDatabaseName()
        {
            var databaseName = ConfigurationManager.AppSettings.Get("PrimaryDatabase");
            return databaseName;
        }

        public string getWebServiceUrl()
        {
            var webserviceUrl = ConfigurationManager.AppSettings.Get("PrimaryWebService");
            return webserviceUrl;
        }
    }
}
