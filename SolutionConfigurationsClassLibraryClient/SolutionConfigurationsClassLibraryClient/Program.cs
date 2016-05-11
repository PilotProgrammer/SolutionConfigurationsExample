using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionConfigurationsClassLibrary;

namespace SolutionConfigurationsClassLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment this code to use the ExternalDataAccessSettings class for connection string / web service url
            // settings, as opposed to the app.debug.config/app.release.config arrangement.  
            /*
            var dataAccessSettings = new ExternalDataAccessSettings();
            DatabaseConnection conn = new DatabaseConnection(dataAccessSettings);
            WebServiceClient ws = new WebServiceClient(dataAccessSettings);
            */

            DatabaseConnection conn = new DatabaseConnection();
            WebServiceClient ws = new WebServiceClient();

            FancyCalculator calc = new FancyCalculator(conn, ws);
            int result = calc.DoFancyStuffWithANumber(5);
            Console.ReadLine();
        }
    }
}
