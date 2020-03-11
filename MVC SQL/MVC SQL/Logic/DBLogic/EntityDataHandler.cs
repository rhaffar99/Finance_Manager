using MVC_SQL.Models;
using MVC_SQL.Models.Entity_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Logic
{
    public static class EntityDataHandler
    {
        //Store basic quote data
        public static void storeData(TestFinanceModel vehicle)
        {
            using (FinanceVehiclesDbContext context = new FinanceVehiclesDbContext())
            {
                context.FinanceModelSet.Add(vehicle);
                context.SaveChanges();
            }
        }

        //Store list of daily quotes
        public static void storeData(DailyFinanceModelList vehicle)
        {
            using (FinanceVehiclesDbContext context = new FinanceVehiclesDbContext())
            {
                context.DailyFinanceModelSet.AddRange(vehicle.dailyFinanceModelList);
                context.SaveChanges();
            }
        }

        //Store list of weekly quotes
        public static void storeData(WeeklyFinanceModelList vehicle)
        {
            using (FinanceVehiclesDbContext context = new FinanceVehiclesDbContext())
            {
                context.WeeklyFinanceModelSet.AddRange(vehicle.weeklyFinanceModelList);
                context.SaveChanges();
            }
        }

        //Store list of monthly quotes
        public static void storeData(MonthlyFinanceModelList vehicle)
        {
            using (FinanceVehiclesDbContext context = new FinanceVehiclesDbContext())
            {
                context.MonthlyFinanceModelSet.AddRange(vehicle.monthlyFinanceModelList);
                context.SaveChanges();
            }
        }

        //Store list of basic quotes
        public static void storeData(List<TestFinanceModel> vehicleList)
        {
            using (FinanceVehiclesDbContext context = new FinanceVehiclesDbContext())
            {
                context.FinanceModelSet.AddRange(vehicleList);
                context.SaveChanges();
            }
        }

        //Pull list of basic quotes
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
