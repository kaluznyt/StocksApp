using StocksApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksApp.Services.Stocks
{
    public interface IStockService
    {
        ObservableCollection<Stock> GetAllQuotations();
    }
}
