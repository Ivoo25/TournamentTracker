using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> connections { get; private set; } = new List<IDataConnection>();
        //Only the GlobalConfig class can set this property, but anyone can get it
        public static void initializeConnections(bool database, bool textFiles)
        {
            if (database)
            {

                SqlConnector sql = new SqlConnector();
                connections.Add(sql);
            }

            if (textFiles)
            {
                TextConnector text = new TextConnector();
                connections.Add(text);
            }
        }
    }
}
