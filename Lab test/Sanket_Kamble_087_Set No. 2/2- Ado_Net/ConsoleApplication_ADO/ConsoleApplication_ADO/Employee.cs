using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_ADO
{
    class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public float Salary { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Salary;
        }
    }
}
