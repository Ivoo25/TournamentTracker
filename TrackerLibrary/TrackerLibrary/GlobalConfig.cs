using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Data.SqlClient;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection connections { get; private set; }
        //Only the GlobalConfig class can set this property, but anyone can get it
        public static void initializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                    SqlConnector sql = new SqlConnector();
                    connections = (sql);
                    break;
                case DatabaseType.TextFile:
                    TextConnector text = new TextConnector();
                    connections = (text);
                    break;
                default:
                    break;
            }
        }

        public static string cnnString(string name)
            => ConfigurationManager.ConnectionStrings[name].ConnectionString;



    }

}
