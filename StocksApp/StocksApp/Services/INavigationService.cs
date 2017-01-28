using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

public interface INavigationService
{
    void GoBack();
    void NavigateTo(string page);
    void NavigateTo(string page, object parameter);
}
