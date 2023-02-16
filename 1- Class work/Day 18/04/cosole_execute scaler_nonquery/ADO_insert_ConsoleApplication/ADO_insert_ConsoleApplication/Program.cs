using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_insert_ConsoleApplication
{

    public class Productinsert
    {

        public void  product_insert()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    //Create an instance of SqlCommand class, specifying the T-SQL command 
                    //that we want to execute, and the connection object.
                    SqlCommand cmd = new SqlCommand("insert into Product values ('Iphone',1,750000)", connection);
                    connection.Open();
                    //Since we are performing an insert operation, use ExecuteNonQuery() 
                    //method of the command object. ExecuteNonQuery() method returns an 
                    //integer, which specifies the number of rows inserted
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Inserted Rows = " + rowsAffected + "<br/>");

                    //Set to CommandText to the update query. We are reusing the command object, 
                    //instead of creating a new command object
                    cmd.CommandText = "update Product set Price= 15000 where Id = 2";
                    //use ExecuteNonQuery() method to execute the update statement on the database
                    rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated Rows = " + rowsAffected + "<br/>");

                    //Set to CommandText to the delete query. We are reusing the command object, 
                    //instead of creating a new command object
                    cmd.CommandText = "Delete from Product where Id = 1002";
                    //use ExecuteNonQuery() method to delete the row from the database
                    rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("Deleted Rows = " + rowsAffected + "<br/>");


                }
                catch (Exception ex)
                {
                    // Handle Exceptions, if any
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
class Program
    {
        static void Main(string[] args)
        {
            Productinsert pi = new Productinsert();
            pi.product_insert();
            Console.ReadLine();
        }
    }
}
