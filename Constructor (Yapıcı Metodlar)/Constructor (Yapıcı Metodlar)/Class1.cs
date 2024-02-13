using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor__Yapıcı_Metodlar_
{
    class Araba
    {
        public string marka { get; set; }
        public string model { get; set; }
        public string renk { get; set; }
        public bool otomatik { get; set; }
        public int hiz { get; set; }
        public void show()
        {
            Console.WriteLine($"{marka} {model} {renk} {(otomatik ? "Otomatik" : "Manuel")}");
        }
        public Araba()//paremtresiz constructor
        {
            hiz = 0;
        }
        public Araba(int hiz)
        {
            this.hiz = hiz;
        }
        public Araba(string model,string marka,string renk,bool otomatik)
        {
            this.model = model;
            this.marka = marka;
            this.renk = renk;
            this.otomatik = otomatik;
        }
        public Araba(string model, string marka, string renk, bool otomatik,int hiz):this(marka,model,renk,otomatik)//yukardaki cons referans verir
        {
        
            this.hiz= hiz;
        }
        public void Start()
        {
            hiz = 30;
            Console.WriteLine($"{this.marka} {this.model} çalıştırılıyor\nHız:{hiz}");
        }
        public void Hizlan()
        {
            if (hiz < 120)
            {
                hiz += 30;
                Console.WriteLine($"{this.marka} {this.model} hizlaniyor\nHız:{hiz}");
            }
            else
                Console.WriteLine("Max limit");
        }
        public void Yavasla()
        {
            if (hiz > 30)
            {
                hiz -= 30;
                Console.WriteLine($"{this.marka} {this.model} duruyot..\nHız:{hiz}");
            }
            else
                Console.WriteLine("Max limit");
        }
        public void Dur()
        {

            hiz = 0;
            Console.WriteLine($"{this.marka} {this.model} durdu\nHız:{hiz}");
        }
        public void Menu()
        {
            string secim;
            bool durum = true;
            while (durum)
            {
                Console.Write("1-Bilgileri Goster\n2-Basla\n3-Hizlan\n4-Yavasla\n5-Dur\nHerhangi Tus cikis\nSecim:");
                secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        this.show(); break;
                    case "2":
                        this.Start(); break;
                    case "3":
                        this.Hizlan(); break;
                    case "4":
                        this.Yavasla(); break;
                    case "5":
                        this.Dur(); break;
                    default:
                        durum = false; break;
                }
            }
        }

    }
    class Yorumlar
    {
        public int id { get; set; }
        public string text { get; set; }
        public Yorumlar(string text)
        {
            var rnd = new Random();
            id=rnd.Next(100000);
            this.text = text;
        }
    }
    class Product
    {
        public int id { get; set; }
        public string  name { get; set; }
        public double fiyat { get; set; }
        public Yorumlar[] yorumlar { get; set; }
        public Product() 
        {
            yorumlar = new Yorumlar[100];//baslatılmalıyoksa hatalı olur
            var rnd = new Random();
            id = rnd.Next(11111, 55555);
        }
        public Product(int id):this()//yukardaki constrıuctorus calistirmaya yarar
        {
         
            this.id = id;
        }
        public Product(string name,double fiyat)
        {
            yorumlar = new Yorumlar[100];
            var rnd = new Random();
            id = rnd.Next(11111, 55555);
            this.name = name;
            this.fiyat = fiyat;
        }
    }
}
