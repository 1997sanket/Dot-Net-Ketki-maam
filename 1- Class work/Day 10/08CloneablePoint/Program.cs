using System;
namespace CloneablePoint
{
    public class program
    {
        public static void Main()
        {
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            Console.WriteLine("Cloned p3 and stored new Point in p4");
            Point p3 = new Point(100, 100,"Jane");
            Point p4 = (Point)p3.Clone();

            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);
            Console.WriteLine("p3: {0}", p3.GetHashCode());
            Console.WriteLine("p4: {0}", p4.GetHashCode());

            p4.X = 99;
            p4.Y = 99;
            p4.desc.PetName ="hello";
            Console.WriteLine("After modification:");
            Console.WriteLine("p3: {0}", p3);
            Console.WriteLine("p4: {0}", p4);

            Console.ReadLine();
           
        }
    }
}
