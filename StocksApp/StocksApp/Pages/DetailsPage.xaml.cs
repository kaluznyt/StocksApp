using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace StocksApp.Pages
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.DetailsViewModel;
            //App.Locator.DetailsViewModel.Person = person;
        }
    }
}
