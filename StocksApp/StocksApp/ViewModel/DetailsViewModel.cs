using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksApp.ViewModel
{
    public class DetailsViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
                
        public DetailsViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
