using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml;
using Npgsql;
//using Microsoft.SqlServer.Management.Sdk.Sfc;
namespace UIotwsqkude
{
    public class DatebaseReader:IReader
    {
        protected DataTable dataTable;
        private readonly string inputProvider;

        public DatebaseReader(string inputProviderProvider)
        {
            this.inputProvider = inputProviderProvider;
            dataTable =new DataTable();
        }
        public virtual string ReadLine()
        {
            string output = "";
            if (inputProvider == "console")
            {
                string commandAsString = Console.ReadLine();
                bool isSql =  bool.Parse(ConfigurationManager.AppSettings["isSQL"]);
                bool isPostgre = bool.Parse(ConfigurationManager.AppSettings["isPostgre"]);
                if (isSql)
                {
                   // output = output + infoProviderSQL();
                }
                else if(isPostgre)
                {
                    output = output + infoProviderPostgre();
                }
                return output;
            }
            else
            {
                output= "no , batka";
            }
            return output;
        }

        private string infoProviderPostgre()
        {
            string output = " ";
           
            string query1 = "SELECT id, name FROM pets";
            var postgreConn=new  NpgsqlConnection("Server=127.0.0.1;User Id=misho; " +
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
