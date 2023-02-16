using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemaFirst
{
    class Program
    {



        static void Main(string[] args)
        {

            mydbEntities db = new mydbEntities();

            //Create

            Employee e = new Employee();
            e.Name = "Aditya";
            e.Salary = 2000;


            db.Employees.Add(e);    //WIll go in Added State

            int c = db.SaveChanges();   //WIll update in Database

            Console.WriteLine("Successfully added " + c + " record");







            //Read

            List<Employee> employees = db.Employees.ToList<Employee>();

            foreach (Employee employee in employees)
            {
                Console.WriteLine("{0} {1}  {2}", employee.Id, employee.Name, employee.Salary);
            }






            //Update

            Employee ex = db.Employees.Find(2);

            ex.Name = "Tambi";
            
            db.SaveChanges();






            //Delete

            Employee e1 = db.Employees.Find(1004);

            db.Employees.Remove(e1);

            int c1 = db.SaveChanges();

            Console.WriteLine("Successfully deleted " + c1 + " record");

        }
    }
}
