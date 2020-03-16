using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Logic.DBLogic
{
    public static class DbInterfacer
    {
        public static bool checkIfDuplicate(string tickerTag)
        {
            using (FinanceVehiclesDbContext context = new FinanceVehiclesDbContext())
            {
                if (context.FinanceModelSet.Any(t => t.MarketTicker == tickerTag)) {
                    return true;
                }
                return false;
            }
        }
    }
}
