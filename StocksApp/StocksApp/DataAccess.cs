using SQLite.Net;
using StocksApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StocksApp
{
    public class DataAccess
    {
        SQLiteConnection dbConn;

        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
            dbConn.CreateTable<Stock>();
        }

        public List<Stock> GetAllEmployees()
        {
            return dbConn.Query<Stock>("Select * From [Stock]");
        }
        public int SaveEmployee(Stock aEmployee)
        {
            return dbConn.Insert(aEmployee);
        }
        public int DeleteEmployee(Stock aEmployee)
        {
            return dbConn.Delete(aEmployee);
        }
        public int EditEmployee(Stock aEmployee)
        {
            return dbConn.Update(aEmployee);
        }
    }
}
