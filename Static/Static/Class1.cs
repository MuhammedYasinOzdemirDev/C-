using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Student
    {
        public int no { get; set; }
        public string name { get; set; }
        public static string okul;//ortak kullanılan değişken
        public Student(string name,int no)
        {
            this.name = name;
            this.no = no;
            okul = "Marmara Üniversitesi";
        }
        public void Show()
        {
            Console.WriteLine($"{name} {no} {okul}");
        }
    }
    static class Matamatik//static olarak yardım amacli karakok vs almak gibi işlemler yazılır
    {
        public static int Toplama(params object[] data)
        {
            int t = 0;
            foreach(object o in data)
            {
                t += (int) o;
            }
            return  t;
        }
        public static int cikarma(params object[] data)
        {
            int t = 0;
            foreach (object o in data)
            {
                t -= (int)o;
            }
            return t;
        }
        public static int carpma(params object[] data)
        {
            int t = 1;
            foreach (object o in data)
            {
                t *= (int)o;
            }
            return t;
        }
    }
    class Product
    {
        public int productid { get; }
        public double price { get; set; }
        public string name { get; set; }
        public Product(string name,double price)
        {
               var rnd=new Random();
            productid = rnd.Next(10000, 50000);
            this.price= price;
            this.name = name;
        }
    }
    static class ProductManager
    {
        private static Product[] products;
        public static int size { get; }
        public static int konum;
         static ProductManager()
        {
            products=new Product[100];
            size = 100;
            konum = 0;
            
        }
        public static void Add(Product product)
        {
            if (konum < size - 1)
            {
                products[konum] = product;
                konum++;
            }

            }
        public static void delete(int id)
        {
           if(konum > 0)
            {
                products[id-1] = null;
                for(int i = 0; i < konum; i++)
                {
                    if (products[i] != null)
                    {
                        products[i] = products[i];
                    }
                    else
                    {
                        products[i] = products[i + 1];
                        products[i + 1] = null;
                    }
                }
                konum--;
            }
            
        }
        public static void ShowProducks()
        {
            for (int i=0;i<konum;i++)
                Console.WriteLine((i+1)+".\t"+products[i].name + "\t" + products[i].price);
        }
        public static Product GetProductId(int id)
        {
            return products[id];
        }
        public static Product GetProductName(string name)
        {
            foreach(var product in products)
            {
                if(product.name == name)
                    return product;
            }
            return null;
        }
        public static Product[] GetProducts()
        {
            return products;
        }

    }
}
