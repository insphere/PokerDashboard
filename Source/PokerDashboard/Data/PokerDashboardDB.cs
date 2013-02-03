using System;
using System.Data.EntityClient;
using System.IO;

namespace PokerDashboard.Data
{
    /// <summary>
    /// Partial class for the DB context.
    /// </summary>
    public partial class PokerDashboardDB
    {
        // Creates 
        public static PokerDashboardDB Create()
        {
            string baseFolder = AppDomain.CurrentDomain.BaseDirectory;

            string sqlLiteConnectionString = string.Format(
                "data source=\"{0}\";datetimeformat=Ticks",
                Path.Combine(baseFolder, "App_Data\\pd.sqlite"));

            string entityConnectionString = new EntityConnectionStringBuilder
                {
                    Metadata = "res://*/Data.PokerDashboardDBContext.csdl|res://*/Data.PokerDashboardDBContext.ssdl|res://*/Data.PokerDashboardDBContext.msl",
                    Provider = "System.Data.SQLite",
                    ProviderConnectionString = sqlLiteConnectionString,
                }.ConnectionString;

            return new PokerDashboardDB(entityConnectionString);
        }
    }
}