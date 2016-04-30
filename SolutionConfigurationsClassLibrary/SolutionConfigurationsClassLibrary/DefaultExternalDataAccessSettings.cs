using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace SolutionConfigurationsClassLibrary
{
    class DefaultExternalDataAccessSettings : IExternalDataAccessSettings
    {
        public string DatabaseName
        {
            get
            {
                var databaseName = Properties.Settings.Default.PrimaryDatabase;
                return databaseName;
            }
        }

        public string WebServiceUrl
        {
            get
            {
                var webserviceUrl = Properties.Settings.Default.PrimaryWebService;
                return webserviceUrl;
            }
        }
    }
}
