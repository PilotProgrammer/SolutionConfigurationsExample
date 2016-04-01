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
            DatabaseConnection conn = new DatabaseConnection();
            WebServiceClient ws = new WebServiceClient();

            FancyCalculator calc = new FancyCalculator(conn, ws, true);
            int result = calc.DoFancyStuffWithANumber(5, true);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
