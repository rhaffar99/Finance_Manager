using MVC_SQL.Models.Entity_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models.VehicleViewModels
{
    public class AggregateVehicleQuotesModel
    {
        public AggregateVehicleQuotesModel(List<MonthlyFinanceModel> monthlyModelList, List<WeeklyFinanceModel> weeklyModelList, List<DailyFinanceModel> dailyModelList)
        {
            this.monthlyModelList = monthlyModelList;
            this.weeklyModelList = weeklyModelList;
            this.dailyModelList = dailyModelList;
        }
        public List<MonthlyFinanceModel> monthlyModelList { get; set; }
        public List<WeeklyFinanceModel> weeklyModelList { get; set; }
        public List<DailyFinanceModel> dailyModelList { get; set; }
    }
}
