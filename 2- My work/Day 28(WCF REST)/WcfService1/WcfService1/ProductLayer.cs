using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class ProductLayer
    {
        private static List<Product> products = new List<Product>();


        //CREATE
        public void saveProduct(Product p)
        {
            products.Add(p);
        }



        //READ
        public List<Product> getAllProducts()
        {
            return products;
        }


    }
}