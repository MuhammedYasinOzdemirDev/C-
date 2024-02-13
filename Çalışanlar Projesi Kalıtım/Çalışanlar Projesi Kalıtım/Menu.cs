using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışanlar_Projesi_Kalıtım
{
     class Menu
    {
        private bool durum = true;


        public  Menu(string isim, string departman, double maas)
        {
            Yonetici yonetici = new Yonetici(isim, departman,maas);

            while (durum)
            {
                Console.Write("1-Çalışanları göster\n2-Çalışan ekle\n3-Çalışan sil\n4-Çalışan bilgileri değiştir.\n5-Çalışana is yaptır.\n6-Çıkış\n\n\tsecim:");
                String secim = Console.ReadLine();

                if (secim.Equals("1"))
                {
                    if (yonetici.calisanlar.Count != 0)
                    {
                        yonetici.CalisanlariGoster();
                    }
                    else
                    {
                        Console.WriteLine("Çalısan yok...");
                    }
                }
                else if (secim.Equals("2"))
                {
                    yonetici.CalisanEkle();
                }
                else if (secim.Equals("3"))
                {
                    if (yonetici.calisanlar.Count != 0)
                    {
                        yonetici.CalisanSil();
                    }
                    else
                    {
                        Console.WriteLine("Çalısan yok...");
                    }
                }
                else if (secim.Equals("4"))
                {
                    yonetici.CalisanBilgiDegistir();
                }
                else if (secim.Equals("5"))
                {
                    yonetici.IsVer();
                }
                else if (secim.Equals("6"))
                {
                    durum = false;
                }
                else
                    Console.WriteLine("Hatalı kodlama...");
            }
        }
    }
}
