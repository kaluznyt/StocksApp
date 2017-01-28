using GalaSoft.MvvmLight;
using StocksApp.Model;
using StocksApp.Services.Stocks;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksApp.ViewModel
{
    public class StockListViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IStockService _stockService;

        public ObservableCollection<Stock> Stocks
        {
            get
            {
                return _stockService.GetAllQuotations();
            }
        }

        public StockListViewModel(INavigationService navigationService, IStockService stockService)
        {
            _stockService = stockService;
            _navigationService = navigationService;
        }
    }
}
