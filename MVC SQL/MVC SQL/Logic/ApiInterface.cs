using MVC_SQL.Models;
using MVC_SQL.Models.API_Models;
using MVC_SQL.Models.Entity_Models;
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

        static public object jsonToAPIModel(string model, string json)
        {
            switch (model)
            {
                case "quote":
                    return JsonConvert.DeserializeObject<GlobalQuoteModel>(json).quote;
                case "daily":
                    return JsonConvert.DeserializeObject<TimeSeriesDailyModel>(json);
                case "weekly":
                    return JsonConvert.DeserializeObject<TimeSeriesWeeklyModel>(json);
                case "monthly":
                    return JsonConvert.DeserializeObject<TimeSeriesMonthlyModel>(json);
                default:
                    throw new InvalidOperationException();
            }
        }

        static public Dictionary<string, string> JsonFullPop(string companyTickerTag)
        {
            Dictionary<string, string> jsonDict = new Dictionary<string, string>();
            jsonDict.Add("quote", ApiInterface.generateJsonAsync(companyTickerTag, "GLOBAL_QUOTE").Result);
            jsonDict.Add("daily", ApiInterface.generateJsonAsync(companyTickerTag, "TIME_SERIES_DAILY_ADJUSTED").Result);
            jsonDict.Add("weekly", ApiInterface.generateJsonAsync(companyTickerTag, "TIME_SERIES_WEEKLY_ADJUSTED").Result);
            jsonDict.Add("monthly", ApiInterface.generateJsonAsync(companyTickerTag, "TIME_SERIES_MONTHLY_ADJUSTED").Result);
            return jsonDict;
        }

        static public QuoteEndpointModel vehicleFullPop(Dictionary<string, string> jsonDict)
        {
            QuoteEndpointModel modelToReturn = null;
            foreach (KeyValuePair<string,string> modelKeyPair in jsonDict)
            {
                var deserializedData = jsonToAPIModel(modelKeyPair.Key, modelKeyPair.Value);
                dynamic modelToStore;
                switch (modelKeyPair.Key)
                {
                    case "quote":
                        modelToReturn = (QuoteEndpointModel)deserializedData;
                        modelToStore = new TestFinanceModel((QuoteEndpointModel)deserializedData);
                        break;
                    case "daily":
                        modelToStore = new DailyFinanceModelList((TimeSeriesDailyModel) deserializedData);
                        break;
                    case "weekly":
                        modelToStore = new WeeklyFinanceModelList((TimeSeriesWeeklyModel) deserializedData);
                        break;
                    case "monthly":
                        modelToStore = new MonthlyFinanceModelList((TimeSeriesMonthlyModel) deserializedData);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                EntityDataHandler.storeData(modelToStore);
            }
            return modelToReturn;
        }
    }
}
