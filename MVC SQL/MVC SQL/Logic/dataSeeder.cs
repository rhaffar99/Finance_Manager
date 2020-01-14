using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_SQL.Models;

namespace MVC_SQL.Logic
{
    public static class DataSeeder
    {
        public static void seedInitial(TestFinanceModelDbContext context)
        {
            if (!context.set.Any())
            {
                var investments = new List<TestFinanceModel>
                {
                    new TestFinanceModel {Id = 1, FinanceVehicle = "Stock", MarketTicker = "TSLA", CurrentValue = 0, PreviousMonthValue = 0},
                    new TestFinanceModel {Id = 2, FinanceVehicle = "Bond ETF", MarketTicker = "VAB", CurrentValue = 0, PreviousMonthValue = 0},
                    new TestFinanceModel {Id = 3, FinanceVehicle = "Mixed ETF", MarketTicker = "VIDY", CurrentValue = 0, PreviousMonthValue = 0},
                    new TestFinanceModel {Id = 4, FinanceVehicle = "Mixed ETF", MarketTicker = "VNQ", CurrentValue = 0, PreviousMonthValue = 0},
                    new TestFinanceModel {Id = 5, FinanceVehicle = "Mixed ETF", MarketTicker = "VGH", CurrentValue = 0, PreviousMonthValue = 0},
                };

                context.set.AddRange(investments);
                context.SaveChanges();
            }
        }
    }
}
