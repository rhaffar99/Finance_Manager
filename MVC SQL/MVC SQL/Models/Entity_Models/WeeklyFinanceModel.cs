using MVC_SQL.Models.API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models.Entity_Models
{
    public class WeeklyFinanceModelList
    {
        public WeeklyFinanceModelList(TimeSeriesWeeklyModel modelList)
        {
            weeklyFinanceModelList = new List<WeeklyFinanceModel>();
            foreach (KeyValuePair<DateTime, WeeklyQuoteModel> WeeklyTimeQuote in modelList.weeklyQuotes)
            {
                weeklyFinanceModelList.Add(new WeeklyFinanceModel(WeeklyTimeQuote.Value));
            }
        }
        public List<WeeklyFinanceModel> weeklyFinanceModelList { get; set; }
    }

    public class WeeklyFinanceModel
    {
        private WeeklyFinanceModel()
        {

        }
        public WeeklyFinanceModel(WeeklyQuoteModel model)
        {
            this.open = model.open;
            this.high = model.high;
            this.low = model.low;
            this.close = model.close;
            this.adjusted_close = model.adjusted_close;
            this.volume = model.volume;
            this.dividend_amount = model.dividend_amount;
        }

        public int Id { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public double adjusted_close { get; set; }
        public string volume { get; set; }
        public double dividend_amount { get; set; }
    }
}
