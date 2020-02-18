using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Models.API_Models
{
    public class QuoteEndpointModel
    {
        string symbol { get; set; }
        double open { get; set; }
        double high { get; set; }
        double low { get; set; }
        double price { get; set; }
        int volume { get; set; }
        string latest_trading_day { get; set; }
        double previous_close { get; set; }
        double change { get; set; }
        string change_percent { get; set; }
    }
}
