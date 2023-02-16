using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ServiceModel;
using System.Runtime.Serialization;


namespace MyRESTService
{
    [DataContract]
    public  class Product
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public int Price { get; set; }
    }

    public class Productscoll
    {
       private static readonly Productscoll _instance = new Productscoll();
       
       private Productscoll() { } 
       
       public static Productscoll Instance 
       { 
                get { return _instance; } 
       } 
        public List<Product> ProductList 
        { 
               get { return products; } 
        } 
        public Product GetProduct(int id)
        {
          var result= (from r in products where r.ProductId == id select r).ToList<Product>().First<Product>();

          return result;
        }
        private List<Product> products = new List<Product>() 
        { 
                new Product() { ProductId = 1, Name = "TV", CategoryName = "Category 1", Price=10}, 
                new Product() { ProductId = 2, Name = "LCD", CategoryName = "Category 2", Price=5}, 
                new Product() { ProductId = 3, Name = "Projector", CategoryName = "Category 3", Price=15}, 
                new Product() { ProductId = 4, Name = "LED", CategoryName = "Category 1", Price=9} 
        }; 
    }
}

