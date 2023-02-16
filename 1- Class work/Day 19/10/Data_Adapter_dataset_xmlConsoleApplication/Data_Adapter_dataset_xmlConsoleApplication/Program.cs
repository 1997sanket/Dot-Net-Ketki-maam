using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Data_Adapter_dataset_xmlConsoleApplication
{
    public class Product
    {
        public void displayproduct()
        {        // Create an instance of SqlDataAdapter. Spcify the command and the connection
            string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
          SqlConnection connection = new SqlConnection(ConnectionString);
           
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Product", connection);
                // Create an instance of DataSet, which is an in-memory datastore for storing tables
               DataSet dataset = new DataSet();
                // Call the Fill() methods, which automatically opens the connection, executes the command 
                // and fills the dataset with data, and finally closes the connection.    //no open method
                int n= dataAdapter.Fill(dataset);
               Console.WriteLine(n);
                Console.WriteLine(dataset.GetXml());
                Console.WriteLine(dataset.Tables[0]);
                 dataset.Tables[0].TableName = "Products";
                DataTable dt = dataset.Tables["Products"];
                    // DataTable dt = dataset.Tables[0];
                            foreach (DataRow row in dt.Rows)
                                      {
                                  foreach (DataColumn col in dt.Columns)
                                 Console.Write(row[col] +"\n name of row= "+row+" \n name of column= "+col);
                               Console.WriteLine("----------------------------------");
                                   }
               

            }
        }
    

    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.displayproduct();
            Console.ReadLine();
        }
    }
}
