using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_net_practice
{
    class Program
    {
        private static ProductLayer layer = new ProductLayer();

        static void Main(string[] args)
        {
            Product p = new Product() { Name = "Mouse", Price = 500};

            //Create
            layer.saveProduct(p);


            //Read
            layer.getProducts().ToList().ForEach(product => Console.WriteLine(product));


            //Update
            p.Id = 3;
            p.Price = 1000;
            layer.updateProduct(p);



            //Delete
            layer.deleteProductById(1);
        }
    }
}
