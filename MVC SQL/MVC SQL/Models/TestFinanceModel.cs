using System;

namespace MVC_SQL.Models
{
    public class TestFinanceModel
    {
        public int Id { get; set; }
        public string FinanceVehicle { get; set; }
        public string MarketTicker { get; set; }
        public int CurrentValue { get; set; }
        public int PreviousMonthValue { get; set; }

        public TestFinanceModel() {}

        /*private string calculatePriceChange()
        {
            return ((CurrentValue - PreviousMonthValue) * 100).ToString() + "%";
        }*/
    }
}
