using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConfigurationsClassLibrary
{
    public class FancyCalculator
    {
        protected DatabaseConnection dbConn;
        protected WebServiceClient wsClient;

        public FancyCalculator(DatabaseConnection dbConn, WebServiceClient wsClient)
        {
            this.dbConn = dbConn;
            this.wsClient = wsClient;
        }

        public int DoFancyStuffWithANumber(int aNumber)
        {
            var multiplier = this.getMultiplierValueFromDatabase();
            var result = this.makeCalculation(multiplier);
            this.reportResultsToWebService(result);

            return result;
        }

        protected int getMultiplierValueFromDatabase()
        {
            this.dbConn.connect();
            return this.dbConn.getValueToUseForCalculation();
        }

        protected int makeCalculation(int multiplierValue)
        {
            int result = multiplierValue * 10;
            return result;
        }

        protected void reportResultsToWebService(int result)
        {
            this.wsClient.sendMessage("Result of FancyCalculator: " + result.ToString());
        }
    }

}
