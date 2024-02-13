using Abstarct_ve_Interface_Uygulama_Repository_Pattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_ve_Interface_Uygulama_Repository_Pattern.DataAccesss.Abstract
{
    interface IRepository<TEntity>//generic tanımlarız Girlen sınıfa göre değişir
    {
        public TEntity GetById(int id);


        public void Update(TEntity entity);


        public void Create(TEntity entity);


        public void Delete(int id);

    }
}
