using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIotwsqkude
{
    class PostgreDatebaseReader:DatebaseReader
    {
        public PostgreDatebaseReader(string inputProviderProvider) : base(inputProviderProvider)
        {
        }

        public override string ReadLine()
        {
            string output = " ";

            string query1 = "SELECT id, name FROM pets";
            var postgreConn = new NpgsqlConnection("Server=127.0.0.1;User Id=misho; " +
                         "Password=vinetu41;Database=petshop;");

            postgreConn.Open();

            NpgsqlCommand command = new NpgsqlCommand(query1, postgreConn);

            NpgsqlDataReader dr = command.ExecuteReader();

            // Output rows 
            while (dr.Read())
                output = output + string.Format("{0}\t{1} \n", dr[0], dr[1]);



            postgreConn.Close();

            return output;
        }
    }
}
