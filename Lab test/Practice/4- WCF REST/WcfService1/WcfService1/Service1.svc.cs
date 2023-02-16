using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static Practice_dbEntities db = new Practice_dbEntities();

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }




        public void saveProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
        }

        public List<Product> getProducts()
        {
            
            return db.Products.ToList();
        }

        public void updateProduct(Product p)
        {
            Product x = db.Products.Where(product => product.Id == p.Id).FirstOrDefault();

            if (x != null)
            {
                x.Id = p.Id;
                x.Name = p.Name;
                x.Price = p.Price;
            }

            db.SaveChanges();
        }

        public void deleteProduct(Product p)
        {
            var x = db.Products.Where(pro => pro.Id == p.Id).FirstOrDefault();

            

            if (x != null)
            {
                db.Products.Remove(x);
                db.SaveChanges();
            }


            
        }
    }
}
