using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_enumerator
{
    class Program
    {
        static void Main(string[] args)
        { 
            company cp = new company();

            foreach (employee ep in cp)
                Console.WriteLine(ep.Name);
            Console.ReadKey();
            // Manually work with IEnumerator.
           //IEnumerator i = cp.GetEnumerator();
           //i.MoveNext();
           // employee  emp = (employee )i.Current;
           // Console.WriteLine("-------{0} is getting sal of  rs{1} ", emp.Name, emp.Salary );
           // Console.ReadKey();
           //  while (i.MoveNext())
           // {               
                
           //     employee  myemp = (employee)i.Current;
           //     Console.WriteLine("{0}  sal {1}",myemp.Name, myemp.Salary);
           // }
            Console.ReadLine();

        }
    }
}
