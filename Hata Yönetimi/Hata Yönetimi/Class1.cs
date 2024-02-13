using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yönetimi
{
     class Product
    {
         int _id; 
        private string _name;
        public int Id { 
            get {
                return _id;
            }
            set{
                try
                {
                    _id = value;
                }
                catch(FormatException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            } }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 15)
                    throw new Exception("En fazla 15 karekter girilebilir...");
                _name = value;
            }
        }
    }
    //Exception sınıfı
    class LoginException : Exception
    {
         LoginException(string message) :base(message)
            {
     
        }
    }
}
