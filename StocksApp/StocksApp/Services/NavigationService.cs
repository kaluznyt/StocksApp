using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StocksApp.Services
{
    public class NavigationService : INavigationService
    {

        private readonly Dictionary<string, Type> _pages = new Dictionary<string, Type>();
        private NavigationPage _navigation;

        public bool AddPage(string name, Type type)
        {
            if (!_pages.ContainsKey(name))
            {
                _pages.Add(name, type);
                return true;
            }

            return false;
        }

        public void GoBack()
        {
            _navigation.PopAsync();
        }

        public void NavigateTo(string page)
        {
            _navigation.PushAsync(
                _pages[page]
                        .GetTypeInfo()
                        .DeclaredConstructors
                        .FirstOrDefault(
                                    c => !c.GetParameters().Any())
               .Invoke(null) as Page ?? new Page());
        }

        public void NavigateTo(string page, object parameter)
        {
            _navigation.PushAsync(
                _pages[page]
                        .GetTypeInfo()
                        .DeclaredConstructors
                        .FirstOrDefault(
                        c =>
                        {
                            var param = c.GetParameters();
                            return param.Count() == 1 && param[0].ParameterType == parameter.GetType();
                        })
                    .Invoke(new object[] { parameter }) as Page ?? new Page());
        }
        public void Initialize(NavigationPage navigation)
        {
            _navigation = navigation;
        }

    }
}
