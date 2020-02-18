using System;

namespace MVC_SQL.Models
{
    public class TestFinanceModel
    {
        public int Id { get; set; }
        public string MarketTicker { get; set; }
        public int CurrentValue { get; set; }
        public int PercentageChange { get; set; }

    }
}
