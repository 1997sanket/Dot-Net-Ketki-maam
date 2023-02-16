using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_net_practice
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Price;
        }
    }
}
