using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StocksApp.Model;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

namespace StocksApp.Services.Stocks
{
    public class StockService : IStockService
    {
        public ObservableCollection<Stock> GetAllQuotations()
        {
            return QuotationsJsonResultToCollection(GetStockQuotationsJson());
        }

        private static string GetStockQuotationsJson()
        {
            var httpClient = new HttpClient();
            var asyncTask =  httpClient.GetAsync(Config.AllStockQuotesUri);

            Task.WaitAll(asyncTask);

            var response = asyncTask.Result;

            if (response.IsSuccessStatusCode)
            {
                var taskReadAsString = response.Content.ReadAsStringAsync();
                Task.WaitAll(taskReadAsString);

                return taskReadAsString.Result;
            }
            else return null;
        }

        private static ObservableCollection<Stock> QuotationsJsonResultToCollection(string json)
        {
            JObject jObject = JObject.Parse(json);
            var stocks = new ObservableCollection<Stock>();

            foreach (var item in jObject["items"] as JArray)
            {
                stocks.Add(new Stock { Symbol = (string)item["fullName"] });
            }

            return stocks;
        }
    }
}
