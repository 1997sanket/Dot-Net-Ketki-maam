using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_enumerator
{
   public class company:IEnumerable
    {
       employee[] e=new employee[5];

       public company ()
       {
           e[0] = new employee() { Name = "Raj", Salary = 50000 };
           e[1] = new employee() { Name = "Anita", Salary = 80000 };
           e[2] = new employee() { Name = "Mona", Salary = 30000 };
           e[3] = new employee() { Name = "Geeta", Salary = 90000 };
           e[4] = new employee() { Name = "Ravi", Salary = 70000 };
       
       
       }

      public IEnumerator GetEnumerator()
       {
           return e.GetEnumerator();
           //throw new NotImplementedException();
       }

    }
}
