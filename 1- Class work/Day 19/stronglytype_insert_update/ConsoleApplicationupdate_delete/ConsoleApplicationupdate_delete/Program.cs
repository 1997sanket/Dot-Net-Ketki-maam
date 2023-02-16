using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationupdate_delete
{
    class Program
    {
        static void Main(string[] args)
        {

            Product p1 = new Product { Name = "LCD", Price = 90000, Qty = 5 };
            insertData indata = new insertData();
            int a=indata.AddData(p1);
            Console.WriteLine("{0}", a);

            Console.WriteLine("----------------------------");
            Product r = indata.search(1007);
            Console.WriteLine("{0}{1}{2}", r.Id, r.Name, r.Price);

            Console.WriteLine("----------------------------");
            List<Product> pl= indata.search("TVvv");
            if (pl != null)
            {
                foreach (var x in pl)
                    Console.WriteLine("{0}{1}{2}", x.Id, x.Name, x.Price);
            }
            else { Console.WriteLine("record with TVvv not found"); }
            Console.WriteLine("----------------------------");
            int no = indata.Del(2002);
            Console.WriteLine("deleted {0}", no);
            Console.ReadLine();
        }
    }
}
