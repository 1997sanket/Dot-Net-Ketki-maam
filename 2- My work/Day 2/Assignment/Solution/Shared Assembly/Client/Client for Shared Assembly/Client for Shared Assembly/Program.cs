using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharedLibrary;

namespace Client_for_Shared_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();

            Console.WriteLine(m.sqr(2));

            Console.WriteLine(m.cube(3));


            Console.ReadLine();
        }
    }
}
