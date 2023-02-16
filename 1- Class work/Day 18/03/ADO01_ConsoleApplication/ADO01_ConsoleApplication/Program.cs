﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO01_ConsoleApplication
{
    public class Productlayer
    {
        public void Products()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Pass the connection to the command object, so the command object knows on which
                // connection to execute the command
                SqlCommand cmd = new SqlCommand("Select * from Product", con);
                // Open the connection. Otherwise you get a runtime error. An open connection is
                // required to execute the command

                con.Open();
                Console.WriteLine("connected");
                SqlDataReader rdr = cmd.ExecuteReader(); //returns object of sqldatareder
                while (rdr.Read())
                {


                    Console.WriteLine("{0} {1} {2}", rdr["Id"], rdr["Name"], rdr["Price"]);
                }


            }

        }

        public class Program
        {

            static void Main(string[] args)
            {
                Productlayer el = new Productlayer();

                el.Products();
                Console.ReadLine();
            }
        }
    }
}
