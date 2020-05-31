using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_3_cours.src.bin.dbNetwork
{
    static class DBSQLServerUtils
    {
        public static SqlConnection
               GetDBConnection(string datasource, string database, string username, string password)
        {
            //
            // DESKTOP-5TGIQQC\SQLEXPRESS;Initial Catalog=RG_database;Integrated Security=True
            //
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
