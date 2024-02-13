using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Uygulamasi
{
    internal class Hesap
    {
        public string kadi { get; set; }
        public string parola { get; set; }
        public double bakiye { get; set; }
        public Hesap(string kadi, string parola, double bakiye)
        {
            this.kadi = kadi;
            this.parola = parola;
            this.bakiye = bakiye;
        }
        public void ParaYatir(double miktar)
        {
            bakiye += miktar;
            Console.WriteLine("Para Yatırıldı...");
        }
        public void ParaCek(double miktar)
        {
            if (bakiye - miktar > 0)
            {
                bakiye -= miktar;
                Console.WriteLine("Para Cekildi...");
            }
            else
                Console.WriteLine("Yetersiz Bakiye...");
        }
     
    }
}
