using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Configuration;
using System.Data;

namespace ConsoleApplicationupdate_delete
{
    class insertData
    {
        public SqlConnection getconnection()
        {    SqlConnection sqlconn = new SqlConnection();
            string connstring = ConfigurationManager.ConnectionStrings["demo"].ConnectionString;
            sqlconn.ConnectionString = connstring;
                return sqlconn;
        }
        public int AddData(Product e)
        {   SqlConnection sqlconn=null;
            SqlCommand sqlcmd;
            int record = 0;
            try
            {
                sqlconn = getconnection();
                 sqlcmd = new SqlCommand("storedata", sqlconn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@pname", SqlDbType.NVarChar).Value = e.Name;
                sqlcmd.Parameters.AddWithValue("@pprice", SqlDbType.Float).Value = e.Price;
                sqlcmd.Parameters.AddWithValue("@pqty", SqlDbType.Int).Value = e.Qty;
                sqlconn.Open();
                record = sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {   sqlconn.Close();
                sqlconn = null;
            }


            return record;


        }
        public Product search(int id)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            Product p = null;
            try
            {
                sqlconn = getconnection();
                sqlconn.Open();
                sqlcmd = new SqlCommand("select * from Product where id=@pid", sqlconn);
                sqlcmd.Parameters.AddWithValue("@pid", id);
                SqlDataReader rd = sqlcmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        p = new Product();
                        p.Id = Convert.ToInt32(rd["Id"]);
                        p.Name = rd["Name"].ToString();
                        p.Price = Convert.ToSingle(rd["Price"]);
                        p.Qty = Convert.ToInt32(rd["Qty"]);
                        break;
                    }
                 }       
             }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
                sqlconn = null;
            }

            return p;
        }
        public List<Product> search(string  name)
        {          
            SqlConnection sqlconn=null;
            SqlCommand sqlcmd;
            List<Product> pl=null;
            try
            {       sqlconn = getconnection();
                sqlconn.Open();
                sqlcmd = new SqlCommand("select * from Product where name=@pid", sqlconn);
                sqlcmd.Parameters.AddWithValue("@pid", name);
                SqlDataReader rd = sqlcmd.ExecuteReader();
                if (rd.HasRows)
                {
                    pl = new List<Product>();
                    while (rd.Read())
                    {
                       Product p = new Product();
                        p.Id = Convert.ToInt32(rd["Id"]);
                        p.Name = rd["Name"].ToString();
                        p.Price = Convert.ToSingle(rd["Price"]);
                        p.Qty = Convert.ToInt32(rd["Qty"]);
                       pl.Add(p);
                    }
                  } 
             }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
                sqlconn = null;
            }
            return pl;
        }

        public int Del(int id)
        {
            SqlConnection sqlconn = null;
            SqlCommand sqlcmd;
            int no=0;
            try
            {
                sqlconn = getconnection();
                sqlconn.Open();
                sqlcmd = new SqlCommand("delete from Product where id=@pid", sqlconn);
                sqlcmd.Parameters.AddWithValue("@pid", id);
                no = sqlcmd.ExecuteNonQuery();
                     }
            catch (SqlException se)
            { Console.WriteLine(se.Message); }
            finally
            {
                sqlconn.Close();
                sqlconn = null;
            }
            return no;
        }



    }
}


    

