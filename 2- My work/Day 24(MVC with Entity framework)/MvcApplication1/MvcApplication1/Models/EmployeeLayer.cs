using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class EmployeeLayer
    {

        public static List<Employee> Employees
        {
            get
            {
                List<Employee> employees = new List<Employee>();

                //String conString = @"Data Source=(localdb)\Projects;Initial Catalog=mydb;Integrated Security=True;";

                String conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                using (SqlConnection con = new SqlConnection(conString))
                {

                    SqlCommand cmd = new SqlCommand("select * from Employee", con);

                    con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        Employee e = new Employee();

                        e.Id = Convert.ToInt32(sdr["Id"]);
                        e.Name = sdr["Name"].ToString();
                        e.Salary = Convert.ToSingle(sdr["Salary"]);

                        employees.Add(e);
                    }
                }
                return employees;
            }
        }


        public static int saveEmployee(Employee e)
        {
            String conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("insert into Employee values(@Name, @Salary)", con);

                cmd.Parameters.AddWithValue("@Name", e.Name.ToString());
                cmd.Parameters.AddWithValue("@Salary", Convert.ToSingle(e.Salary));

                con.Open();

                var result = cmd.ExecuteNonQuery();

                return result;
            }
        }


        //Delete
        public static int deleteEmployee(int id)
        {
            String conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("delete from Employee where Id = @ID", con);

                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();

                var result = cmd.ExecuteNonQuery();

                return result;
            }
        }



        public static int updateEmployee(Employee e)
        {
            String conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("select * from Employee where Id = @Id", con);

                cmd.Parameters.AddWithValue("@ID", e.Id);

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                Employee ex = new Employee();

                while (sdr.Read())
                {
                    ex.Id = Convert.ToInt32(sdr["Id"]);
                    ex.Name = sdr["Name"].ToString();
                    ex.Salary = Convert.ToSingle(sdr["Salary"]);

                    break;
                }

                con.Close();
                int result = 0;

                //If Id's match
                if (e.Id == ex.Id)
                {
                    //Update
                    ex.Name = e.Name;
                    ex.Salary = e.Salary;

                    cmd = new SqlCommand("update Employee set Name = @Name, Salary = @Salary where Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Name", ex.Name);
                    cmd.Parameters.AddWithValue("@Salary", ex.Salary);
                    cmd.Parameters.AddWithValue("@Id", ex.Id);

                    con.Open();

                    result = cmd.ExecuteNonQuery();

                }
                    
                con.Close();
                return result;
            }
        }
    }
}