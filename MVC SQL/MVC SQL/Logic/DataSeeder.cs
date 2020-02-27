using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_SQL.Models;

namespace MVC_SQL.Logic
{
    public static class DataSeeder
    {
        public static void seedInitial(FinanceVehiclesDbContext context)
        {
            if (!context.set.Any())
            {
                var investments = new List<TestFinanceModel>
                {
                    new TestFinanceModel ("TSLA", 0, "0"),
                    new TestFinanceModel ("VAB", 0, "0"),
                    new TestFinanceModel ("VIDY", 0, "0"),
                    new TestFinanceModel ("VNQ", 0, "0"),
                    new TestFinanceModel ("VGH", 0, "0")
                };

                context.set.AddRange(investments);
                context.SaveChanges();
            }
        }
    }
}
