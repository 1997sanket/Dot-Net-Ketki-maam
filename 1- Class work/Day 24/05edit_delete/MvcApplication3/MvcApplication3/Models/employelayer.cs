using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class Employeelayer
    {
        public List<Employee> Employees
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;

                List<Employee> employees = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("select * from Emp", con);

                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = Convert.ToInt32(rdr["Id"]);
                        employee.Name = rdr["Name"].ToString();
                        employee.Gender = rdr["Gender"].ToString();
                        employee.City = rdr["City"].ToString();

                        employees.Add(employee);
                    }
                }

                return employees;
            }
        }
        public int store(Employee e)
        {

            int record = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand sqlcmd = new SqlCommand("store", con);
                sqlcmd.CommandType = CommandType.StoredProcedure;


                sqlcmd.Parameters.AddWithValue("@e_nm", SqlDbType.NVarChar).Value = e.Name;
                sqlcmd.Parameters.AddWithValue("@e_gn", SqlDbType.NVarChar).Value = e.Gender;
                sqlcmd.Parameters.AddWithValue("@e_city", SqlDbType.NVarChar).Value = e.City;

                record = sqlcmd.ExecuteNonQuery();

            }


            return record;

        }
        public Employee Display(int Id)
        {
            Employee employee=null;
            List<Employee> emp = new List<Employee>();
            string connectionString = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand sqlcmd = new SqlCommand("select * from Emp where Id=@eId",con);
                sqlcmd.Parameters.AddWithValue("@eId", Id);
                SqlDataReader rdr = sqlcmd.ExecuteReader();
               
              
                
                    while (rdr.Read())
                    {
                        employee = new Employee();
                            employee.Id = Convert.ToInt32(rdr["Id"]);
                            employee.Name = rdr["Name"].ToString();
                            employee.Gender = rdr["Gender"].ToString();
                            employee.City = rdr["City"].ToString();
                            emp.Add(employee);
                            break;
                        }
                    }

            

            return employee;
        }

        public int update(Employee e)
        {

            int record = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
               string qry= "UPDATE Emp SET Name=@nm, Gender=@gn, City=@cty where Id=@id";

                SqlCommand sqlcmd = new SqlCommand(qry, con);
                sqlcmd.Parameters.AddWithValue("@nm", e.Name);
                sqlcmd.Parameters.AddWithValue("@gn", e.Gender);
                sqlcmd.Parameters.AddWithValue("@cty", e.City);
                sqlcmd.Parameters.AddWithValue("@id", e.Id);
                


                record = sqlcmd.ExecuteNonQuery();

            }


            return record;

        }
        public int deldata(int Id)
        {
            int dno;

           
            string connectionString = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
               
                SqlCommand sqlcmd = new SqlCommand("delete from Emp where Id=@eId", con);
                sqlcmd.Parameters.AddWithValue("@eId", Id);
                 dno = sqlcmd.ExecuteNonQuery();
            }
            return dno;
        }
               
    }
}