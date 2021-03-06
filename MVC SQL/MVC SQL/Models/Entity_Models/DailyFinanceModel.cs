﻿using MVC_SQL.Models.API_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models.Entity_Models
{
    public class DailyFinanceTimeSeriesParentModel
    {
        public DailyFinanceTimeSeriesParentModel(TimeSeriesDailyModel TimeSeriesParentModel)
        {
            dailyFinanceTimeSeriesParentModel = new List<DailyFinanceModel>();
            foreach (KeyValuePair<DateTime, DailyQuoteModel> DailyTimeQuote in TimeSeriesParentModel.dailyQuotes)
            {
                dailyFinanceTimeSeriesParentModel.Add(new DailyFinanceModel(DailyTimeQuote.Value, TimeSeriesParentModel.metaData.symbol, DailyTimeQuote.Key));
            }
        }
        public List<DailyFinanceModel> dailyFinanceTimeSeriesParentModel { get; set; }
    }

    public class DailyFinanceModel
    {
        private DailyFinanceModel()
        {

        }
        public DailyFinanceModel(DailyQuoteModel model, string marketTicker, DateTime date)
        {
            this.open = model.open;
            this.high = model.high;
            this.low = model.low;
            this.close = model.close;
            this.adjusted_close = model.adjusted_close;
            this.volume = model.volume;
            this.dividend_amount = model.dividend_amount;
            this.split_coefficient = model.split_coefficient;
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
        public double split_coefficient { get; set; }
        public string market_ticker { get; set; }
        public DateTime date { get; set; }
    }
}
