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
            var dataAccessSettings = new ExternalDataAccessSettings();
            DatabaseConnection conn = new DatabaseConnection(dataAccessSettings);
            WebServiceClient ws = new WebServiceClient(dataAccessSettings);

            FancyCalculator calc = new FancyCalculator(conn, ws);
            int result = calc.DoFancyStuffWithANumber(5);
            Console.ReadLine();
        }
    }
}
