using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIotwsqkude
{
    class SQLDatebaseReader:DatebaseReader
    {
        public SQLDatebaseReader(string inputProviderProvider) : base(inputProviderProvider)
        {
            
        }

        public override string ReadLine()
        {
            string output = " ";

            string connectionString = @"Data Source= .;Initial Catalog=BookStoreDbFluent;Integrated Security=True";


            string query = "select * from dbo.Books";
            // 1. Instantiate the connection

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();


            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // this will query your database and return the result to your datatable
            da.Fill( this.dataTable);//da.InsertCommand()
            string s = dataTable.Columns[0].ColumnName;
            // Console.WriteLine( "{0} ",s);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    output = output + item;
                }
            }

            conn.Close();
            da.Dispose();

            return output;
        }
    }
}
