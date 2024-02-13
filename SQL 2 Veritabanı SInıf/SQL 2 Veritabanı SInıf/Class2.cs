using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_2_Veritabanı_SInıf
{
    interface IProductDal
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void Create(Product p);
        void Update(Product p);
        void Delete(Product p);
    }
}
