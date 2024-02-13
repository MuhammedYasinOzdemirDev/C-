using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Sınıf
{
    internal class Ogrenci
    {
            public int no { get; set; }
            public string ad { get; set; }
            public string sube { get; set; }
            public Ogrenci(int no, string ad, string sube)
            {
                this.no = no;
                this.ad = ad;
                this.sube = sube;
            }
            public Ogrenci()
            {
            }
        }
    class Urun
    {
        public int fiyat { get; set; }
        public string ad { get; set; }
        public string aciklama { get; set; }
    }
    }

