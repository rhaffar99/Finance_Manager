using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models.API_Models
{
    public class TimeSeriesWeeklyModel
    {
        [JsonProperty("Weekly Adjusted Time Series")]
        public Dictionary<DateTime, WeeklyQuoteModel> weeklyQuotes { get; set; }

    }

    public class WeeklyQuoteModel
    {

        [JsonProperty("1. open")]
        public double open { get; set; }

        [JsonProperty("2. high")]
        public double high { get; set; }

        [JsonProperty("3. low")]
        public double low { get; set; }

        [JsonProperty("4. close")]
        public double close { get; set; }

        [JsonProperty("5. adjusted close")]
        public double adjusted_close { get; set; }

        [JsonProperty("6. volume")]
        public string volume { get; set; }

        [JsonProperty("7. dividend amount")]
        public double dividend_amount { get; set; }
    }
}
