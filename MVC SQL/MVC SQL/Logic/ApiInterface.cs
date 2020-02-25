using MVC_SQL.Models.API_Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVC_SQL.Logic
{
    public class ApiInterface
    {
        const string apiKey = "ECQW7XET4W7RC9TT";
        private static HttpClient client = new HttpClient();

        static public string generateSearchUrl(string symbol, string function)
        {
            string baseUrl = "https://www.alphavantage.co/query?";
            baseUrl += $"function={function}";
            baseUrl += $"&symbol={symbol}";
            baseUrl += $"&apikey={apiKey}";

            return baseUrl;
        }

        static public async Task<string> generateJsonAsync(string symbol, string function)
        {
            string baseUrl = generateSearchUrl(symbol, function);
            var responseString = await client.GetStringAsync(baseUrl);
            while (responseString == "0")
            {
                responseString = await client.GetStringAsync(baseUrl);
            }
            return responseString;
        }

        static public QuoteEndpointModel jsonToAPIModelQuote (string json)
        {
            GlobalQuoteModel jsonModel = JsonConvert.DeserializeObject<GlobalQuoteModel>(json);
            return jsonModel.quote;
        }

        static public TimeSeriesDailyModel jsonToAPIModelDaily(string json)
        {
            TimeSeriesDailyModel jsonModel = JsonConvert.DeserializeObject<TimeSeriesDailyModel>(json);
            return jsonModel;
        }

        static public TimeSeriesWeeklyModel jsonToAPIModelWeekly(string json)
        {
            TimeSeriesWeeklyModel jsonModel = JsonConvert.DeserializeObject<TimeSeriesWeeklyModel>(json);
            return jsonModel;
        }

        static public TimeSeriesMonthlyModel jsonToAPIModelMonthly(string json)
        {
            TimeSeriesMonthlyModel jsonModel = JsonConvert.DeserializeObject<TimeSeriesMonthlyModel>(json);
            return jsonModel;
        }
    }
}
