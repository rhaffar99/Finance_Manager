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
                    return JsonConvert.DeserializeObject<TimeSeriesDailyModel>(json).dailyQuotes;
                case "weekly":
                    return JsonConvert.DeserializeObject<TimeSeriesWeeklyModel>(json).weeklyQuotes;
                case "monthly":
                    return JsonConvert.DeserializeObject<TimeSeriesMonthlyModel>(json).monthlyQuotes;
                default:
                    throw new InvalidOperationException();
            }
        }

        /*static public void JsonToApiModel (string model, string json)
        {
            var deserializedVehicleData = ApiInterface.jsonToAPIModel(model, json);
            try
            {
                var deserializedVehicleData = ApiInterface.jsonToAPIModel(model, json);
                modelToStore = new TestFinanceModel(deserializedVehicleData);
            }
            catch (Exception ex)
            {
                ErrorModel Error = new ErrorModel(ex.Message, ex.StackTrace);
                return View("Error", Error);
            }
            EntityDataHandler.storeData(modelToStore);
        }*/

        static private Dictionary<string, string> JsonFullPop(string companyTickerTag)
        {
            Dictionary<string, string> jsonDict = new Dictionary<string, string>();
            jsonDict.Add("quote", ApiInterface.generateJsonAsync(companyTickerTag, "GLOBAL_QUOTE").Result);
            jsonDict.Add("daily", ApiInterface.generateJsonAsync(companyTickerTag, "TIME_SERIES_DAILY_ADJUSTED").Result);
            jsonDict.Add("weekly", ApiInterface.generateJsonAsync(companyTickerTag, "TIME_SERIES_WEEKLY_ADJUSTED").Result);
            jsonDict.Add("monthly", ApiInterface.generateJsonAsync(companyTickerTag, "TIME_SERIES_MONTHLY_ADJUSTED").Result);
            return jsonDict;
        }

        static public void vehicleFullPop(Dictionary<string, string> jsonDict)
        {
            foreach (KeyValuePair<string,string> modelKeyPair in jsonDict)
            {
                var deserializedData = jsonToAPIModel(modelKeyPair.Key, modelKeyPair.Value);
                dynamic modelToStore;
                switch (modelKeyPair.Key)
                {
                    case "quote":
                        modelToStore = new TestFinanceModel((QuoteEndpointModel)deserializedData);
                        break;
                    case "daily":
                        modelToStore = new DailyFinanceModel((DailyQuoteModel)deserializedData);
                        break;
                    case "weekly":
                        modelToStore = new WeeklyFinanceModel((WeeklyQuoteModel)deserializedData);
                        break;
                    case "monthly":
                        modelToStore = new MonthlyFinanceModel((MonthlyQuoteModel)deserializedData);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                EntityDataHandler.storeData(modelToStore);
            }

        }
    }
}
