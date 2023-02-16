using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationentitydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Model_empdeptContainer obj = new Model_empdeptContainer();
            var x = from rng in obj.EMPs select rng;

            var d = x.FirstOrDefault<EMP>();
            Console.WriteLine(d.Dept); //observe dynamic proxy

            foreach (var r in x)
                Console.WriteLine("{0} {1} {2} {3} {4} ======{5}", r.Id, r.Name, r.Salary, r.DeptId, r.Dept, r);



            List<EMP> Le = obj.EMPs.ToList<EMP>();
            //  adddata();
            // deletedata();

        }
        static void showeager()
        { Model_empdeptContainer obj = new Model_empdeptContainer();
            
            var result= from rng in obj.EMPs.Include("") select rng;
        
        
        }

        static void adddata()
        {
            Model_empdeptContainer db = new Model_empdeptContainer();
            EMP p1 = new EMP();
            p1.Id = 7;
            p1.Name = "rinku";
            p1.Salary = 50000;
            p1.DeptId = 1;
            db.EMPs.Add(p1);
            db.SaveChanges();
        
        }
        static void deletedata()
        {
            Model_empdeptContainer db = new Model_empdeptContainer();
          EMP p1 = db.EMPs.Find(1);
            db.EMPs.Remove(p1);
            db.SaveChanges();

        
        
        }

    }
}
