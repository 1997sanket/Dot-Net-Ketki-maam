using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Ado_net_practice
{

    public class ProductLayer
    {

        //Get Connection class
        public static SqlConnection getConnection()
        {
            String conString = @"Data Source=(localdb)\Projects;Initial Catalog=Practice_db;Integrated Security=True";

            SqlConnection con = new SqlConnection(conString);
            
            return con;
        }


        //Create
        public void saveProduct(Product p)
        {
            SqlConnection con = getConnection();

            SqlCommand cmd = new SqlCommand("insert into Product values(@Name, @Price)", con);
            cmd.Parameters.AddWithValue("@Name", p.Name);
            cmd.Parameters.AddWithValue("@Price", p.Price);

            con.Open();

            int result = cmd.ExecuteNonQuery();

            if(result > 0)
                Console.WriteLine("Successfully inserted 1 record");

            con.Close();

        }




        //Read
        public List<Product> getProducts()
        {
            SqlConnection con = getConnection();
            List<Product> products = new List<Product>();

            SqlCommand cmd = new SqlCommand("select * from Product", con);
           
            con.Open();

            SqlDataReader result = cmd.ExecuteReader();

            while (result.Read())
            {
                Product p = new Product();
                p.Id = Convert.ToInt32(result["Id"]);
                p.Name = result["Name"].ToString(); ;
                p.Price = Convert.ToSingle(result["Price"]);

                products.Add(p);
            }

            con.Close();
            return products;
        }


        

        //Update
        public void updateProduct(Product p)
        {
            SqlConnection con = getConnection();


            SqlCommand cmd = new SqlCommand("update Product set Name = @Name, Price = @Price where Id = @Id", con);
            cmd.Parameters.AddWithValue("@Name", p.Name);
            cmd.Parameters.AddWithValue("@Price", p.Price);
            cmd.Parameters.AddWithValue("@Id", p.Id);

            con.Open();

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
                Console.WriteLine("Successfully updated 1 record");

            con.Close();

        }




        //Delete
        public void deleteProductById(int id)
        {
            SqlConnection con = getConnection();

            SqlCommand cmd = new SqlCommand("delete from Product where Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
                Console.WriteLine("Successfully deleted 1 record");

            con.Close();

        }

    }
}
