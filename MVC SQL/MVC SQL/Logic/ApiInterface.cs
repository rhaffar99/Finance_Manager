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

        static public string generateSearchUrl(string symbol)
        {
            string baseUrl = "https://www.alphavantage.co/query?";
            baseUrl += "function=GLOBAL_QUOTE";
            baseUrl += $"&symbol={symbol}";
            baseUrl += $"&apikey={apiKey}";

            return baseUrl;
        }

        static public async Task<string> generateJsonAsync(string symbol)
        {
            string baseUrl = generateSearchUrl(symbol);
            var responseString = await client.GetStringAsync(baseUrl);
            return responseString;
        }

        static public QuoteEndpointModel jsonToAPIModel (string json, QuoteEndpointModel emptyModel)
        {
            emptyModel = JsonConvert.DeserializeObject<QuoteEndpointModel>(json);
            return emptyModel;
        }
    }
}
