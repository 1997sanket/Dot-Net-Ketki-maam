using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ADO
{
    class Program
    {
        private static EmployeeLayer layer = new EmployeeLayer();


        static void Main(string[] args)
        {
            
            Employee e = new Employee() {Name = "Sanket", Salary = 5000};

            //Insert Employee
            layer.saveEmployee(e);


            //Search by Id
            Employee temp = layer.Search(1);
            Console.WriteLine(temp);


            //Search by Name
            layer.Search("Sanket").ForEach(emp => Console.WriteLine(emp));


            Console.ReadLine();
            
        }
    }
}
