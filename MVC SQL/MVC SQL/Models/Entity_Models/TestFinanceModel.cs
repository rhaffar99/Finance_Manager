using MVC_SQL.Models.API_Models;
using MVC_SQL.Models.Entity_Models;
using System;

namespace MVC_SQL.Models
{
    public class TestFinanceModel
    {
        private TestFinanceModel()
        {

        }
        public TestFinanceModel(QuoteEndpointModel quote)
        {
            this.MarketTicker = quote.symbol;
            this.CurrentValue = quote.open;
            this.PercentageChange = quote.change_percent;
        }

        public TestFinanceModel(string MarketTicker, int CurrentValue, string PercentageChange)
        {
            this.MarketTicker = MarketTicker;
            this.CurrentValue = CurrentValue;
            this.PercentageChange = PercentageChange;
        }

        public int Id { get; set; }
        public string MarketTicker { get; set; }
        public double CurrentValue { get; set; }
        public string PercentageChange { get; set; }

    }
}
