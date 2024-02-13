using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_ve_Interface_Uygulama_Repository_Pattern.Entity
{
     class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
    }
}
