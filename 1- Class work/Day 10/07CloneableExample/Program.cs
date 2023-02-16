using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("***** A First Look at Interfaces *****\n");

            // All of these classes support the ICloneable interface.
            string myStr = "Hello";
            Console.WriteLine(myStr.GetHashCode());
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            Console.WriteLine(unixOS.GetHashCode());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();
            Console.WriteLine(sqlCnn.GetHashCode());
            // Therefore, they can all be passed into a method taking ICloneable.
            CloneMe(myStr);
           CloneMe(unixOS);
            CloneMe(sqlCnn);
            Console.ReadLine();
        }

        private static void CloneMe( ICloneable c )
        {
            // Clone whatever we get and print out the name.
            object theClone = c.Clone();
            Console.WriteLine(theClone.GetHashCode());
            Console.WriteLine("Your clone is a: {0}",     theClone.GetType().Name);
        }
    }
}
