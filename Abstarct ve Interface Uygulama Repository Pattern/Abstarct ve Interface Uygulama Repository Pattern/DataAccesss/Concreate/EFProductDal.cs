
using Abstarct_ve_Interface_Uygulama_Repository_Pattern.DataAccesss.Abstract;
using Abstarct_ve_Interface_Uygulama_Repository_Pattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_ve_Interface_Uygulama_Repository_Pattern.DataAccesss.Concreate
{
     class EFProductDal:IProductRepository
    {
       public Product[] GetProductsCategory(int id)
        {
            return new Product[3];
        }
        public Product GetById(int id)
        {
            return new Product();
        }
        public void Update(Product product) {

        }
        public void Create(Product product)
        {

        }
        public void Delete(int id)
        {

        }

    }
}
