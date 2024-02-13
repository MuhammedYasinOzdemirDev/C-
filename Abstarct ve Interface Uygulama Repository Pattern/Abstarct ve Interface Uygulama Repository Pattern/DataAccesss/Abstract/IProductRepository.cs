using Abstarct_ve_Interface_Uygulama_Repository_Pattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_ve_Interface_Uygulama_Repository_Pattern.DataAccesss.Abstract
{
     interface IProductRepository:IRepository<Product>
    {
        /*  public Product GetById(int id);bunlara gerek yok


          public void Update(Product product);


          public void Create(Product product);


          public void Delete(int id);*/
        Product[] GetProductsCategory(int id);//bu da ek olarak tanımlarız
       
    }
}
