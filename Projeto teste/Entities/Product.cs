using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_teste.Entities
{
    internal class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }




        Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


    }
}
