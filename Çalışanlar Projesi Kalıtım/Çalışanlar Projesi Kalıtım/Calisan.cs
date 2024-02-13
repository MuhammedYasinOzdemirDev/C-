using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışanlar_Projesi_Kalıtım
{
    internal class Calisan
    {
        public string isim { get; set; }
        public string departman { get; set; }
        public double maas { get; set; }
        public Calisan(string isim, string departman, double maas)
        {
            this.maas = maas;
            this.isim = isim;
            this.departman = departman;
        }
        public void Intro()
        {
            Console.WriteLine("İsim:" + isim + "\nDepartman:" + departman + "\nMaas:" + maas);
        }
        public void DepartmanDegis(String departman)
        {
            this.departman = departman;
            Console.WriteLine("Departman değişti...");
        }
    }
    class Yazilimci : Calisan
    {
        public ArrayList bildigi_diler { get; set; }
        public Yazilimci(string isim, string departman, double maas, ArrayList bildigi_diller) : base(isim, departman, maas)
        {
            this.bildigi_diler = bildigi_diler;
        }
        public void Intro()
        {
            base.Intro();
            Console.WriteLine("Bildiği diller " + bildigi_diler);
        }
        public void format_at(String isletim_sistemi)
        {
            Console.WriteLine(isim + " kisisi " + isletim_sistemi + " sistemini yükledi.");
        }
        public void bakim_yap()
        {
            Console.WriteLine(isim + " kisisi  Bakım yaptı...");
        }
        public void DilEkle()
        {
            Console.Write("Dil:");
            var dil = Console.ReadLine();
            this.bildigi_diler.Add(dil);
            Console.WriteLine(dil + " dili eklendi...");
        }
    }
    class Yonetici : Calisan
    {
        public int sorumlu_kisi { get; set; }
        public ArrayList calisanlar { get; }
        public Yonetici(string isim, string departman, double maas) : base(isim, departman, maas)
        {
            this.sorumlu_kisi = 0;
            calisanlar = new ArrayList();
        }
        public void CalisanlariGoster()
        {
            for (int i = 0; i < calisanlar.Count; i++)
            {
                Console.WriteLine((i + 1) + ".");
                Calisan calisan = (Calisan)calisanlar[i];
                calisan.Intro();
            }
        }
        public void CalisanEkle()
        {
            Console.Write("İsim:");
            string isim = Console.ReadLine();
            Console.Write("Departman:");
            string departman = Console.ReadLine();
            double maas = double.Parse(Console.ReadLine());
            ArrayList diller = new ArrayList();
            Yazilimci yazilimci = new Yazilimci(isim, departman, maas, diller);
            calisanlar.Add(yazilimci);
            sorumlu_kisi++;
            Console.WriteLine("Çalışan eklendi...");
        }
        public void CalisanSil()
        {
            CalisanlariGoster();
            Console.Write("Silmek istediğiniz kişinin ismini giriniz:");
            var isim = Console.ReadLine();
            int c = 0;
            for (int i = 0; i < calisanlar.Count; i++)
            {
                var calisan = (Calisan)calisanlar[i];
                if (calisan.isim == isim)
                {
                    calisanlar.Remove(i);
                    c = 1;
                    sorumlu_kisi--;
                    Console.WriteLine("Calisan basarıyla silindi...");
                }
            }
            if (c == 0)
                Console.WriteLine("Çalışan bulunamadı...");
        }
        public void CalisanBilgiDegistir()
        {
            CalisanlariGoster();
            Console.Write("İsim Giriniz:");
            var isim = Console.ReadLine();
            for (int i = 0; i < calisanlar.Count; i++)
            {
                var calisan = (Yazilimci)calisanlar[i];
                if (calisan.isim == isim)
                {
                    while (true)
                    {
                        Console.Write("1-Departman değiştir\n2-Dil ekle\n3-Maas değiştir\n4-Çıkış\n\n secim:");
                        String a = Console.ReadLine();
                        if (a.Equals("1"))
                        {
                            Console.Write("Yeni departman:");
                            String b = Console.ReadLine();
                            calisan.DepartmanDegis(b);
                            Console.WriteLine("Departman değişti...");
                        }
                        else if (a.Equals("2"))
                        {
                            calisan.DilEkle();
                        }
                        else if (a.Equals("3"))
                        {
                            Console.Write("Eski maas:" + calisan.maas + "\nYeni maas:");
                            double maas = double.Parse(Console.ReadLine());
                            calisan.maas = maas;
                            Console.WriteLine("Maas degisti.");
                        }
                        else if (a.Equals("4"))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı kodlama..");
                        }

                    }
                }
            }
        }
        public void IsVer()
        {
            CalisanlariGoster();
            Console.Write("İsim giriniz:");
            var isim = Console.ReadLine();
            for (int i = 0; i < calisanlar.Count; i++)
            {
                var calisan = (Yazilimci)calisanlar[i];
                if (calisan.isim == isim)
                {

                    Console.Write("1-format at\n2-bakım yap\n\n\tsecim:");
                    String a = Console.ReadLine();
                    if (a.Equals("1"))
                    {
                        Console.Write("İsletim sistemi:");
                        String isletim_sistemi = Console.ReadLine();
                        calisan.format_at(isletim_sistemi);
                    }
                    else if (a.Equals("2"))
                    {
                        calisan.bakim_yap();
                    }
                    else
                    {
                        Console.WriteLine("Hatalı kodlama..");
                    }
                }
            }
        }
    }
}

