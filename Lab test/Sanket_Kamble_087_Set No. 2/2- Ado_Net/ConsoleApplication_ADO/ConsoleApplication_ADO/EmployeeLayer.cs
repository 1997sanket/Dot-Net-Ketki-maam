using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ADO
{
    class EmployeeLayer
    {
        
        //For getting Connection
        //Get Connection class
        public static SqlConnection getConnection()
        {
            String conString = @"Data Source=(localdb)\Projects;Initial Catalog=mydb;Integrated Security=True";

            SqlConnection con = new SqlConnection(conString);

            return con;
        }



        //Create
        public void saveEmployee(Employee e)
        {
            SqlConnection con = getConnection();

            SqlCommand cmd = new SqlCommand("insert into Employee values(@Name, @Salary)", con);
            cmd.Parameters.AddWithValue("@Name", e.Name);
            cmd.Parameters.AddWithValue("@Salary", Convert.ToSingle(e.Salary));

            con.Open();

            int result = cmd.ExecuteNonQuery();

            if(result > 0)
                Console.WriteLine("Successfully added 1 Employee");
        }




        //Search by Id
        public Employee Search(int id)
        {
            SqlConnection con = getConnection();

            SqlCommand cmd = new SqlCommand("select * from Employee where Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            Employee e = new Employee();

            while (sdr.Read())
            {
                e.Id = Convert.ToInt32(sdr["Id"]);
                e.Name = sdr["Name"].ToString();
                e.Salary = Convert.ToSingle(sdr["Salary"]);

                break;
            }

            return e;

        }


       
        //Search by Name
        public List<Employee> Search(String name)
        {
            SqlConnection con = getConnection();

            SqlCommand cmd = new SqlCommand("select * from Employee where Name = @Name", con);
            cmd.Parameters.AddWithValue("@Name", name);

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            List<Employee> employees = new List<Employee>();

            while (sdr.Read())
            {
                Employee e = new Employee();

                e.Id = Convert.ToInt32(sdr["Id"]);
                e.Name = sdr["Name"].ToString();
                e.Salary = Convert.ToSingle(sdr["Salary"]);

                employees.Add(e);
                
            }

            return employees;
        }
    }
}
