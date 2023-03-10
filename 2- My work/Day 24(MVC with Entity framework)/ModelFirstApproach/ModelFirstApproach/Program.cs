using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstApproach
{
    class Program
    {
        static Model_FirstContainer db;



        static Model_FirstContainer getDbLayer()
        {
            if (db == null) db = new Model_FirstContainer();

            return db;
        }


        //Create
        static void insertEmployee(EmployeeTable2 employee)
        {
            Model_FirstContainer db = getDbLayer();

            db.EmployeeTable2.Add(employee);    //Goes in Added state

            int c = db.SaveChanges();   //Changes in Database

            Console.WriteLine("Successfully inserted " + c + " record");
        }




        //Read
        static void readAllEmployees()
        {
            Model_FirstContainer db = getDbLayer();

            var employees = db.EmployeeTable2.ToList();

            foreach(EmployeeTable2 e in employees)
                Console.WriteLine("{0} {1} {2} {3}", e.Id, e.Name, e.Salary, e.DepartmentTable2Id);
        }





        //Update
        static void updateEmployee(EmployeeTable2 e)
        {
            Model_FirstContainer db = getDbLayer();

            EmployeeTable2 e1 = db.EmployeeTable2.Find(e.Id);

            e1.Name = e.Name;
            e1.Salary = e.Salary;
            e1.DepartmentTable2Id = e.DepartmentTable2Id;


            int c = db.SaveChanges();

            Console.WriteLine("Successfully update " + c + " record");


        }




        //Delete
        static void deleteEmployee(int id)
        {
            Model_FirstContainer db = getDbLayer();

            EmployeeTable2 e = db.EmployeeTable2.Find(id);

            db.EmployeeTable2.Remove(e);

            int c = db.SaveChanges();

            Console.WriteLine("Successfully delete " + c + " records");
        }


        static void displayEmployeeByDepartment()
        {
            Model_FirstContainer db = getDbLayer();

            var departments = db.EmployeeTable2.GroupBy(employee => employee.DepartmentTable2Id).Select(e => e).ToList();

            foreach (var department in departments)
            {
                Console.WriteLine("Department = " + department.Key);

                Console.WriteLine("Employees");
                foreach (var employee in department)
                {
                    
                    Console.WriteLine(employee);
                }

                Console.WriteLine();
            }
        }




        static void Main(string[] args)
        {
            //Insert
            insertEmployee(new EmployeeTable2() { Name = "Ashok", Salary = 80000, DepartmentTable2Id = 1 });


            //Read
            readAllEmployees();


            //Update
            updateEmployee(new EmployeeTable2() {Id = 4,  Name = "Etof", Salary = 40000, DepartmentTable2Id = 1});
            

            //Delete
            deleteEmployee(5);


            //Group by departments
            displayEmployeeByDepartment();

            Console.ReadLine();

        }



        
    }
}
