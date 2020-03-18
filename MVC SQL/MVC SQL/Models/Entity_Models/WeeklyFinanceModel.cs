using MVC_SQL.Models.API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models.Entity_Models
{
    public class WeeklyFinanceTimeSeriesParentModel
    {
        public WeeklyFinanceTimeSeriesParentModel(TimeSeriesWeeklyModel TimeSeriesParentModel)
        {
            weeklyFinanceTimeSeriesParentModel = new List<WeeklyFinanceModel>();
            foreach (KeyValuePair<DateTime, WeeklyQuoteModel> WeeklyTimeQuote in TimeSeriesParentModel.weeklyQuotes)
            {
                weeklyFinanceTimeSeriesParentModel.Add(new WeeklyFinanceModel(WeeklyTimeQuote.Value, TimeSeriesParentModel.metaData.symbol, WeeklyTimeQuote.Key));
            }
        }
        public List<WeeklyFinanceModel> weeklyFinanceTimeSeriesParentModel { get; set; }
    }

    public class WeeklyFinanceModel
    {
        private WeeklyFinanceModel()
        {

        }
        public WeeklyFinanceModel(WeeklyQuoteModel model, string marketTicker, DateTime date)
        {
            this.open = model.open;
            this.high = model.high;
            this.low = model.low;
            this.close = model.close;
            this.adjusted_close = model.adjusted_close;
            this.volume = model.volume;
            this.dividend_amount = model.dividend_amount;
            this.market_ticker = marketTicker;
            this.date = date;
        }

        public int Id { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public double adjusted_close { get; set; }
        public string volume { get; set; }
        public double dividend_amount { get; set; }
        public string market_ticker { get; set; }
        public DateTime date {get; set;}
    }
}
