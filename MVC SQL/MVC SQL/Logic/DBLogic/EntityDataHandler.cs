using MVC_SQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Logic
{
    public static class EntityDataHandler
    {
        public static void storeData(TestFinanceModel vehicle)
        {
            using (TestFinanceModelDbContext context = new TestFinanceModelDbContext())
            {
                context.set.Add(vehicle);
                context.SaveChanges();
            }
        }
        public static void storeData(List<TestFinanceModel> vehicleList)
        {
            using (TestFinanceModelDbContext context = new TestFinanceModelDbContext())
            {
                context.set.AddRange(vehicleList);
                context.SaveChanges();
            }
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
