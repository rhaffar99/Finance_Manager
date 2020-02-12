using MVC_SQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Logic
{
    public static class EntityDataHandler
    {
        public static void storeData(List<TestFinanceModel> vehicleList, TestFinanceModelDbContext context)
        {
            context.set.AddRange(vehicleList);
            context.SaveChanges();
        }

        public static List<TestFinanceModel> pullData(IEnumerable<TestFinanceModel> query)
        {
            List<TestFinanceModel> vehicleList = new List<TestFinanceModel>();
            foreach (TestFinanceModel vehicle in query)
            {
                vehicleList.Add(vehicle);
            }
            return vehicleList;
        }
    }
}
