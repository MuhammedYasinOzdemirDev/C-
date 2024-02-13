using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
   class Product
    {
        private double _fiyat;
        public double fiyat//degisken get set gibi kullanilmaya yarar
        {
            get
            {
                    return _fiyat;//fiyat dondururu ama get gerek yok
            }
            set
            {
                if(value>0)//girilen değr value ile temsil edilir
                    _fiyat = value;//kosula gore yazılır
                else
                    _fiyat = 0;//sart saglnmassa otomatik atılır

            }
        }
        private string _name;
        public string name { get { return _name; } set
            {
                if (!string.IsNullOrEmpty(value))//bos veya null degilse 
                    _name = value;//atilir
                else
                    Console.WriteLine("Deger giriniz...");//burda hata fırlatılabilir

            } }
        public bool durum { get; }//set olmadığı için erişilebilir fakat değiştirilemez
        public Product()
        {
            durum = true;
        }
    }
}
