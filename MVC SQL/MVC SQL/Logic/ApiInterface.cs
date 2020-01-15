using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SQL.Logic
{
    public static class ApiInterface
    {
        const string apiKey = "ECQW7XET4W7RC9TT";
        static public string generateSearchUrl(string symbol)
        {
            string baseUrl = "https://www.alphavantage.co/query?";
            baseUrl += "function=GLOBAL_QUOTE";
            baseUrl += $"&symbol={symbol}";
            baseUrl += $"&apikey={apiKey}";

            return baseUrl;
        }
    }
}
