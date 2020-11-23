using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Cita450Project
{
    //This class will be used to control all the connections to the database so that 
    //different computers will only need to change one line 
    class DatabaseConnection
    {
        //this is my data source name 
        private static String connectionString = @"Data Source=MAC18552;
                                Initial Catalog=IceDB;
                                integrated security=SSPI;
                                    persist security info=False;
                                    Trusted_Connection=Yes";
        //This is Liam's data source name 
        //private static String connectionString = "";

        public SqlDataReader SelectFromDB(String query)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, cnn);

            cmd.Connection.Open();

            SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            cmd.Connection.Close();

            return myReader;
        }

        public void RunQueryonDB(String query)
        {
            
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        
    }
}
