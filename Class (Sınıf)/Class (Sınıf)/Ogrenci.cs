using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__Sınıf_
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
}
