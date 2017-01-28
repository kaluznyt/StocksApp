using GalaSoft.MvvmLight;
using StocksApp.Model;
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

        public ObservableCollection<Stock> Stocks { get; }

        public StockListViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Stocks = new ObservableCollection<Stock>
            {
                new Stock
                {
                    Symbol="ASBIS",
                    BuyPrice=2.32m,
                    CurrentPrice=3.23m
                },
                new Stock
                {
                    Symbol="ASBIS2",
                    BuyPrice=2.32m,
                    CurrentPrice=3.23m
                },
                new Stock
                {
                    Symbol="ASBIS3",
                    BuyPrice=2.32m,
                    CurrentPrice=3.23m
                }
            };

        }
    }
}
