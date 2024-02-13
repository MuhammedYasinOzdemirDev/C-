using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Uygulaması_Sınıf
{
    internal class Quiz

    {
        private int soru_index { get; set; }
        private Soru[] sorular { get; set; }
        public int skor { get; set; }
        public Quiz(params Soru[] sorular)
        {
            soru_index = 0;
            this.sorular = sorular;
            skor= 0;
        }
        public Soru GetSoru()
        {
            return this.sorular[this.soru_index];
        }
        public void ShowSoru()
        {
            var s = GetSoru();
            Console.WriteLine($"{this.soru_index+1}.Soru:{s.text}");
            foreach (var cevap in s.cevaplar)
            {
                Console.Write($"{cevap}\t");
            }
            Console.WriteLine();
            Console.Write("Cevap:");
            string cevapp = Console.ReadLine();
            this.Guess(cevapp);
        }
        public void Guess(string cevap)
        {
            var soru = GetSoru();
            if (soru.kontrol(cevap))
            {
                Console.WriteLine("Cevap Doğru...");
                skor += 5;
                this.soru_index++;
                if (sorular.Length != this.soru_index)
                    ShowSoru();
                else 
                    Console.WriteLine($"Quiz bitti...\nSkor:{skor}"); 
                 
            }
            else
            {
                Console.WriteLine("Cevap Yanlış...");
                skor--;
                ShowSoru();
            }
          

        }
    }
    class Soru
    {
        public string text { get; set; }
        public string cevap { get; set; }
        public string[] cevaplar { get; set; }
        public Soru(string text, string[] cevaplar,string cevap)
        {
            this.text = text;
            this.cevap = cevap;
            this.cevaplar = cevaplar;
        }
        public bool kontrol(string verilen_cevap)
        {
            return verilen_cevap.ToLower()==cevap.ToLower();
        }
    }
  

}
