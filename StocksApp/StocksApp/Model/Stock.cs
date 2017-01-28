using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksApp.Model
{
    public class Stock
    {
        public string Symbol { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal BuyPrice { get; set; }
    }
}
