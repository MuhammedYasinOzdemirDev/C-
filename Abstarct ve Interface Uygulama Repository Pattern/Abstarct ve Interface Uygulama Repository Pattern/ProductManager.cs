using Abstarct_ve_Interface_Uygulama_Repository_Pattern.DataAccesss.Abstract;
using Abstarct_ve_Interface_Uygulama_Repository_Pattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_ve_Interface_Uygulama_Repository_Pattern
{
    internal class ProductManager : IProductRepository
    {
        IProductRepository repository;
        public ProductManager(IProductRepository repository)
        {
            this.repository = repository;
        }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
