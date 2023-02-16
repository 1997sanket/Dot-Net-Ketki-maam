using System;
using System.Collections.Generic;
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
        ProductLayer pl = new ProductLayer();

        public string GetData(String id)
        {
            return string.Format("Hello");
        }


        //CREATE
        public void Product(Product p)
        {
            pl.saveProduct(p);
        }
        



        //READ
        public List<Product> Products()
        {
            return pl.getAllProducts();
        }


    }
}
