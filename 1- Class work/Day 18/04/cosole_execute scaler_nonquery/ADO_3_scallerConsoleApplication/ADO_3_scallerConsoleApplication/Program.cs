using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO_3_scallerConsoleApplication
{
    public class Productcount
    {
        public int Product_cnt
        {
            get
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                 int TotalRows=0;
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Select Count(Id) from Product", connection);
                       // connection.Open();
                        //As the T-SQL statement that we want to execute return a single value, 
                        //use ExecuteScalar() method of the command object.
                        //Since the return type of ExecuteScalar() is object, we are type casting to int datatype
                        TotalRows = (int)cmd.ExecuteScalar();
                        

                    }
                    catch (Exception ex)
                    {
                        // Handle Exceptions, if any
                       Console.WriteLine(ex.Message);
                    }
                }
                return  TotalRows;
               
            }
        }
    
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Productcount pcnt = new Productcount();
            int x = pcnt.Product_cnt;
            Console.WriteLine("total number of records are {0}",x);
            Console.ReadLine();
        }
    }
}
