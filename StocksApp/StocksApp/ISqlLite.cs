using SQLite.Net;

namespace StocksApp
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
