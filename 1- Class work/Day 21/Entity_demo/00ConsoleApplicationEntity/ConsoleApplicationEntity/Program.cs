using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplicationEntity
{
    class Program
    {


        static void Main(string[] args)
        {
            DemodataEntities db = new DemodataEntities();

            List<Product> data = db.Products.ToList<Product>();
            foreach (var d in data)
                Console.WriteLine("{0}{1}{2}{3}", d.Id, d.Name, d.Price, d.Qty);
           // adddata();
           // deletedata();
            updatedata(2004);

            Console.WriteLine();
        }
        static void adddata()
        {
            DemodataEntities db = new DemodataEntities();
            Product p1 = new Product();
            p1.Id = 311;
            p1.Name = "TTTTT";
            p1.Price = 90000;
            p1.Qty = 2;
            db.Products.Add(p1);
           // db.Entry(p1).State = EntityState.Added;
            db.SaveChanges();

        }
        static void deletedata()
        {
            DemodataEntities db = new DemodataEntities();
            Product del = db.Products.Find(1010);
            try
            {
                db.Products.Remove(del);
                db.SaveChanges();
            }
            catch
            {
                Console.WriteLine("no record found");
            }
        }
        static void updatedata(int id)
        {

            DemodataEntities db = new DemodataEntities();
            Product up = db.Products.Find(id);
            up.Name = "Vi-------a";
            //  db.Entry(up).State = EntityState.Modified;
            db.SaveChanges();

        }

    }

}

