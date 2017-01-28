using GalaSoft.MvvmLight.Ioc;
using StocksApp.Pages;
using StocksApp.Services;
using StocksApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace StocksApp
{
    public partial class App : Application
    {
        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator => _locator ?? (_locator = new ViewModelLocator());

        public App()
        {
            //InitializeComponent();

            var navigationService = new NavigationService();

            navigationService.AddPage(nameof(MainPage), typeof(MainPage));
            navigationService.AddPage(nameof(DetailsPage), typeof(DetailsPage));
            navigationService.AddPage(nameof(StockListPage), typeof(StockListPage));


            SimpleIoc.Default.Register<INavigationService>(() => navigationService, true);


            navigationService.Initialize(
                            (MainPage = new NavigationPage(new MainPage())) as NavigationPage);

            //var firstPage = new NavigationPage(new MainPage());
            //// Set Navigation page as default page for Navigation Service:
            //navigationService.Initialize(firstPage);
            //// You have to also set MainPage property for the app:
            //MainPage = firstPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
