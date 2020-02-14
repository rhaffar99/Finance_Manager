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
                    new TestFinanceModel {Id = 1, MarketTicker = "TSLA", CurrentValue = 0, PercentageChange = 0},
                    new TestFinanceModel {Id = 2, MarketTicker = "VAB", CurrentValue = 0, PercentageChange = 0},
                    new TestFinanceModel {Id = 3, MarketTicker = "VIDY", CurrentValue = 0, PercentageChange = 0},
                    new TestFinanceModel {Id = 4, MarketTicker = "VNQ", CurrentValue = 0, PercentageChange = 0},
                    new TestFinanceModel {Id = 5, MarketTicker = "VGH", CurrentValue = 0, PercentageChange = 0},
                };

                context.set.AddRange(investments);
                context.SaveChanges();
            }
        }
    }
}
