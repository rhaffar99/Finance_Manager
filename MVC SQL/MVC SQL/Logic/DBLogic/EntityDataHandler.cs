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
        public static void storeData(DailyFinanceTimeSeriesParentModel vehicle)
        {
            using (FinanceVehiclesDbContext context = new FinanceVehiclesDbContext())
            {
                context.DailyFinanceModelSet.AddRange(vehicle.dailyFinanceTimeSeriesParentModel);
                context.SaveChanges();
            }
        }

        //Store list of weekly quotes
        public static void storeData(WeeklyFinanceTimeSeriesParentModel vehicle)
        {
            using (FinanceVehiclesDbContext context = new FinanceVehiclesDbContext())
            {
                context.WeeklyFinanceModelSet.AddRange(vehicle.weeklyFinanceTimeSeriesParentModel);
                context.SaveChanges();
            }
        }

        //Store list of monthly quotes
        public static void storeData(MonthlyFinanceTimeSeriesParentModel vehicle)
        {
            using (FinanceVehiclesDbContext context = new FinanceVehiclesDbContext())
            {
                context.MonthlyFinanceModelSet.AddRange(vehicle.monthlyFinanceTimeSeriesParentModel);
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
