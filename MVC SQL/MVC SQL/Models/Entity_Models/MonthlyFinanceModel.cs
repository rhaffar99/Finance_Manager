using MVC_SQL.Models.API_Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models.Entity_Models
{
    public class MonthlyFinanceModel
    {
        private MonthlyFinanceModel()
        {

        }
        public MonthlyFinanceModel(MonthlyQuoteModel model)
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
        public double volume { get; set; }
        public double dividend_amount { get; set; }
    }
}
