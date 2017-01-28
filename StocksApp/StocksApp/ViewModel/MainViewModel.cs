using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using StocksApp.Pages;
using System.Windows.Input;
using Xamarin.Forms;

namespace StocksApp.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public ICommand NavigateDetailsPage { get; private set; }
        public ICommand NavigateStockListPage { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        public MainViewModel(INavigationService navigationService)
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            _navigationService = navigationService;

            NavigateDetailsPage = new Command(() => Navigate<DetailsPage>());
            NavigateStockListPage = new Command(() => Navigate<StockListPage>());
        }

        private void Navigate<T>()
        {
            //var person = new Person() { Name = "Daniel" };
            //Messenger.Default.Send(person);
            _navigationService.NavigateTo(typeof(T).Name);
        }
    }
}