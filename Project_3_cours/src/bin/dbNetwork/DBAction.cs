using Project_3_cours.src.bin.npc;
using Project_3_cours.src.bin.dbNetwork.connect;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_cours.src.bin.dbNetwork
{
    static class DBAction
    {
        static SqlConnection connection;

        public static List<string[]> GetValue(string query)
        {
            List<string[]> outs = new List<string[]>();

            CreateConnect();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                outs.Add(new string[reader.FieldCount]);
                for (int i = 0; i< reader.FieldCount; i++)
                {
                    outs[outs.Count-1][i] = reader[i].ToString();
                }
{}
            }

            reader.Close();
            connection.Close();

            return outs;
        }





        static void CreateConnect()
        {
            connection = DBUtils.GetDBConnection();
            Console.WriteLine("Getting Connection ...");

            try
            {
                Console.WriteLine("Openning Connection ...");

                connection.Open();

                Console.WriteLine("Connection successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.Read();
        }
    }
}
