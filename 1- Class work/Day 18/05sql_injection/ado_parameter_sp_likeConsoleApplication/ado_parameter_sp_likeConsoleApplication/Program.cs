using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace ado_parameter_sp_likeConsoleApplication
{
    class productdetail
    {
        public void displayproduct(string pname)
        {

          /*  string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
               using (SqlConnection connection = new SqlConnection(ConnectionString))
                 {
                     try
                     {  //"v'; Delete from Product;Select * from Product where Name like 'v"

                         //Build the query dynamically, by concatenating the text, that the user has 
                         //typed into the ProductNameTextBox. This is a bad way of constructing
                         //queries. This line of code will open doors for sql injection attack
                         SqlCommand cmd = new SqlCommand("Select * from Product where Name like '" + pname + "%'", connection);
                         connection.Open();
                     SqlDataReader rd=   cmd.ExecuteReader();
                       while (rd.Read())
                                      Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Price"],rd["Qty"]);
                        }
                     
                     catch(Exception ex)
                     {
                      Console.Write(ex.Message);
                     }
                 }
            */
            /*  string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
               using (SqlConnection connection = new SqlConnection(ConnectionString))
               {
                   try
                   {
                       // Parameterized query. @ProductName is the parameter
                       string Command = "Select * from Product where Name like @ProductName";
                       SqlCommand cmd = new SqlCommand(Command, connection);
                       // Provide the value for the parameter
                       cmd.Parameters.AddWithValue("@ProductName", pname + "%");
                       connection.Open();
                    SqlDataReader rd=   cmd.ExecuteReader();
                        while (rd.Read())
                        {
                        Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Price"],rd["Qty"]);
                        }
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine(ex.Message );
                   }
               }*/
           string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
              using (SqlConnection con = new SqlConnection(ConnectionString))
              {   // The command, that we want to execute is a stored procedure,
                  // so specify the name of the procedure as cmdText
                  SqlCommand cmd = new SqlCommand("spGetProductsByName", con);
                  // Specify that the T-SQL command is a stored procedure
                  cmd.CommandType = System.Data.CommandType.StoredProcedure;

                  // Associate the parameter and it's value with the command object
                  cmd.Parameters.AddWithValue("@ProductName", pname);
                  try
                  {
                      con.Open();
                      SqlDataReader rd = cmd.ExecuteReader();
                      while (rd.Read())
                      {
                          Console.WriteLine("{0} {1} {2} {3}", rd["Id"], rd["Name"], rd["Price"], rd["Qty"]);
                      }
                  }
                  catch (Exception ex)
                  {
                      Console.WriteLine(ex.Message);
                  }

              }

        }  
    
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            productdetail pd = new productdetail();
            
           string s = "d";
           //string s="d';delete from Product;Select * from Product where Name like 'd";
            pd.displayproduct(s);
            Console.ReadLine();
        }
    }
}
