﻿using System;
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
            // the database connection will vary based on debug/release
            DatabaseConnection conn = new DatabaseConnection();

            var dataAccessSettings = new ExternalDataAccessSettings();
            WebServiceClient ws = new WebServiceClient();
            
            FancyCalculator calc = new FancyCalculator(conn, ws);
            int result = calc.DoFancyStuffWithANumber(5);
            Console.ReadLine();
        }
    }
}
