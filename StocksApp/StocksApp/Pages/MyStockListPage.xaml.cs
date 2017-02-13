using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace StocksApp.Pages
{
    public partial class MyStockListPage : ContentPage
    {
        public MyStockListPage()
        {
            //InitializeComponent();
            BindingContext = App.Locator.MyStockListViewModel;
        }
    }
}
