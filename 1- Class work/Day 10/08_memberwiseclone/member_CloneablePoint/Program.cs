using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Program 
    {
        static void Main( string[] args )
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
           
            Console.WriteLine("Cloned p3 and stored new Point in p4");
            Point p3 = new Point(100, 100);
            Point p4 = (Point)p3.Clone();
            
            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            Console.WriteLine("p3: {0}", p3.GetHashCode());
            Console.WriteLine("p4: {0}", p4.GetHashCode());

            p4.X = 99;
            p4.Y = 99;
            Console.WriteLine("After modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
           
            Console.ReadLine();
        }
    }
}
