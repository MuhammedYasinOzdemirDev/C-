using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Giriş
{
    internal class Product
    {
        public Product(int id,string name,double price)
        {
            this.ProductId = id;
            this.Name = name;
            this.Price = price;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
