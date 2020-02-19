using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models.API_Models
{
    public class GlobalQuoteModel
    {
        [JsonProperty("Global Quote")]
        public QuoteEndpointModel quote { get; set; }
    }
    public class QuoteEndpointModel
    {
        [JsonProperty("01. symbol")]
        public string symbol { get; set; }

        [JsonProperty("02. open")]
        public double open { get; set; }

        [JsonProperty("03. high")]
        public double high { get; set; }

        [JsonProperty("04. low")]
        public double low { get; set; }

        [JsonProperty("05. price")]
        public double price { get; set; }

        [JsonProperty("06. volume")]
        public int volume { get; set; }

        [JsonProperty("07. latest trading day")]
        public string latest_trading_day { get; set; }

        [JsonProperty("08. previous close")]
        public double previous_close { get; set; }

        [JsonProperty("09. change")]
        public double change { get; set; }

        [JsonProperty("10. change percent")]
        public string change_percent { get; set; }
    }
}
