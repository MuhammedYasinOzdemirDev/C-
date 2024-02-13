using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_sınıf_ve_interface
{
    interface IPersonel
    {
        public String name { get; set; }
  
        public String departman { get; set; }
        void Bilgi();
    }
    interface IYonetici
    {
        void CalisanEKle();
        void CalisanSil();
    }
    class Yönetici : IPersonel,IYonetici
    {
        public Yönetici(string name,string deparman)
        {
            this.name = name;
            this.departman = deparman;
        }

        public string name { get; set; }

        public string departman { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"{name} {departman} bir yönetcidir...");
        }

        public void CalisanEKle()
        {
            throw new NotImplementedException();
        }

        public void CalisanSil()
        {
            throw new NotImplementedException();
        }
    }
    class Isci : IPersonel
    {
        public Isci(string name, string deparman)
        {
            this.name = name;
            this.departman = deparman;
        }

        public string name { get; set; }
        public string departman { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"{name} {departman}  bir işcidşr...");
        }
    }

    abstract class Sekil
    {
        public int width { get; set; }
        public int height { get; set; }
        public Sekil(int w,int h)
        {
            this.width = w;
            this.height = h;
        }
        public abstract void Draw();
        public  int Alan()
        {
            return width * height;
        }
    }

    class Kare :Sekil
    {
        public Kare(int w, int h):base( w, h)
        {
            
        }
        public override void Draw() {
            Console.WriteLine("Kare Çiziliyor");
        }
    }
    class Daire : Sekil
    {
        public Daire(int w, int h) : base(w, h)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Daire Çiziliyor");
        }
    }
    class Ucgen : Sekil
    {
        public Ucgen(int w, int h) : base(w, h)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Ucgen Çiziliyor");
        }
    }
}
