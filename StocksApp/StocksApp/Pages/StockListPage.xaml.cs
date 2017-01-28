using StocksApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace StocksApp.Pages
{
    public partial class StockListPage : ContentPage
    {


        public StockListPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.StockListViewModel;
          
        }
    }
}
