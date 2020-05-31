using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_3_cours.src.bin.dbNetwork.connect
{
    static class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"DESKTOP-5TGIQQC\SQLEXPRESS";
            string database = "RG_database";
            string username = "proga";
            string password = "963258741!Aa";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
