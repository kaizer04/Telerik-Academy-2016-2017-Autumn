using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIotwsqkude
{
    class DatabaseWriter:IWriter
    {
        private const string connectionString = @"Data Source= .;Initial Catalog=BookStoreDbFluent;Integrated Security=True";
     
        public DatabaseWriter()
        {
            
        }
        //the columns' values separated by space
        public void WriteLine(string input)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            
            SqlCommand myCommand =
                new SqlCommand(
                    "INSERT INTO dbo.Books ( Title, AuthorName,Price, GenreId) VALUES ( 'Xirsig23NNNXX', 'Layla',   1.0, 3)",
                    myConnection);

            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }


    }
}
