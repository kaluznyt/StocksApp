using Newtonsoft.Json.Linq;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksApp.Model
{
    public class Stock
    {
        [PrimaryKey]
        public string Symbol { get; set; }
        public string Short { get; set; }
        public DateTime? LastTransactionTime { get; set; }
        public decimal? CurrentPrice { get; set; }
        public decimal? BuyPrice { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }
        public decimal? Open { get; set; }
        public decimal? Reference { get; set; }
        public decimal? Last { get; set; }
        public int? Volume { get; set; }

        public decimal? PercentChange
        {
            get
            {
                return (Last - Reference) / Reference * 100;
            }
        }

        public static Stock Create(JToken item)
        {
            return new Stock
            {
                Symbol = (string)item["fullName"],
                Short = (string)item["shortName"],
                LastTransactionTime = DateTime.Parse((string)item["time"]),
                Open = ToDecimal(item["openingEx"]),
                Low = ToDecimal(item["lowEx"]),
                High = ToDecimal(item["highEx"]),
                Reference = ToDecimal(item["reference"]),
                Volume = ToInt(item["volume"]),
                Last = ToDecimal(item["exchange"])
            };
        }


        private static decimal ToDecimal(JToken jToken)
        {
            decimal x = 0;
            decimal.TryParse((string)jToken, out x);
            return x;
        }

        private static int ToInt(JToken jToken)
        {
            int x = 0;
            int.TryParse((string)jToken, out x);
            return x;
        }
    }
}
