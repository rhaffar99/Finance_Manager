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
        string symbol { get; set; }

        [JsonProperty("02. open")]
        double open { get; set; }

        [JsonProperty("03. high")]
        double high { get; set; }

        [JsonProperty("04. low")]
        double low { get; set; }

        [JsonProperty("05. price")]
        double price { get; set; }

        [JsonProperty("06. volume")]
        int volume { get; set; }

        [JsonProperty("07. latest trading day")]
        string latest_trading_day { get; set; }

        [JsonProperty("08. previous close")]
        double previous_close { get; set; }

        [JsonProperty("09. change")]
        double change { get; set; }

        [JsonProperty("10. change percent")]
        string change_percent { get; set; }
    }
}
