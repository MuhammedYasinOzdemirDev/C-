using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Uygulamasi
{
   
     class Atm
    {
        public Hesap hesap;
        public bool Login()
        {
            Console.Write("Kullanıcı Adı:");
           string k_adi=Console.ReadLine();
            Console.Write("Paralo:");
            string parolaa=Console.ReadLine();
            if (hesap.kadi == k_adi && hesap.parola == parolaa)
                return true;
            return false;
        }
        public void calis()
        {
           Console.WriteLine("************ YapıKredi **************\n");
            int hak = 5;
            while (true)
            {
                if (Login())
                {
                    Console.WriteLine("Hoşgeldiniz...");
                    break;
                }
                else
                {
                   Console.WriteLine("Yanlış kullanıcı adı veya paralo");
                    hak--;
                }
                if (hak == 0)
                    return;//methodun sonlanmasına yarar.
            }
            String islemler = "1-Bakiye goruntule\n2-Para çek\n3-Para Yatır\n4-q çıkış\n\n  secim:";
            while (true)
            {
                Console.Write(islemler);
                String secim = Console.ReadLine();
                if (secim.Equals("1"))
                {
                    Console.WriteLine("Bakiye:" + hesap.bakiye);
                }
                else if (secim.Equals("2"))
                {
                    Console.Write("Miktar giriniz:");
                    double miktar = double.Parse(Console.ReadLine());
                    hesap.ParaCek(miktar);
                }
                else if (secim.Equals("3"))
                {
                    Console.Write("Miktar giriniz:");
                    double miktar = double.Parse(Console.ReadLine());
                    hesap.ParaYatir(miktar);
                }
                else if (secim.Equals("q"))
                {
                    break;
                }
                else
                {
                   Console.WriteLine("Hatalı kodlama...");
                }
            }


        }
    }
}
