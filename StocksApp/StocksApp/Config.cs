using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;

namespace StocksApp
{
    public static class Config
    {
        public const string AllStockQuotesUri = "http://www.parkiet.com/QuotationProvider/ajax/getQuotations";


        public static string DatabaseFilePath
        {
            get
            {
                var filename = "StocksAppDb.db3";
                string libraryPath = string.Empty;
#if SILVERLIGHT
    // Windows Phone 8
    var path = filename;
#else

#if __ANDROID__
    string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); 
#else
#if __IOS__
        // we need to put in /Library/ on iOS5.1 to meet Apple's iCloud terms
        // (they don't want non-user-generated data in Documents)
        string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
        string libraryPath = Path.Combine (documentsPath, "..", "Library");
#endif
#endif
#endif
                var path = Path.Combine(libraryPath, filename);
                return path;
            }
        }
    }
}