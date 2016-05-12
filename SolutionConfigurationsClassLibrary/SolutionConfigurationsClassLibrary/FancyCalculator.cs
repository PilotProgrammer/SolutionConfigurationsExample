using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConfigurationsClassLibrary
{
    public class FancyCalculator
    {
        protected DatabaseConnection DbConn;
        protected WebServiceClient WsClient;

        public FancyCalculator(DatabaseConnection dbConn, WebServiceClient wsClient)
        {
            this.DbConn = dbConn;
            this.WsClient = wsClient;
        }

        public int DoFancyStuffWithANumber(int aNumber)
        {
            var multiplier = this.GetMultiplierValueFromDatabase();
            var result = this.MakeCalculation(multiplier);
            this.ReportResultsToWebService(result);

            return result;
        }

        protected int GetMultiplierValueFromDatabase()
        {
            this.DbConn.Connect();
            return this.DbConn.GetValueToUseForCalculation();
        }

        protected int MakeCalculation(int multiplierValue)
        {
            int result = multiplierValue * 10;
            return result;
        }

        protected void ReportResultsToWebService(int result)
        {
            this.WsClient.SendMessage("Result of FancyCalculator: " + result.ToString());
        }
    }
}
