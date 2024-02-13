using Class_Sınıf;

Ogrenci ogrenci=new Ogrenci();//1 tanimlama
ogrenci.ad = "Muhammed Yasin";
ogrenci.no = 171421005;
ogrenci.sube = "2.sınıf";
Ogrenci ogrenci2=new Ogrenci(171421005,"Ahmet","3.sınıf");//2 tanimlama
Ogrenci ogrenci3 = new Ogrenci()
{
    ad = "Yasin",
    no = 166,
    sube = "10-A"
};
//Gosterim
Console.WriteLine($"{ogrenci.ad} {ogrenci.no} {ogrenci.sube}");
Console.WriteLine($"{ogrenci2.ad} {ogrenci2.no} {ogrenci2.sube}");
Console.WriteLine($"{ogrenci3.ad} {ogrenci3.no} {ogrenci3.sube}");
//dizide olusturulabilir
Ogrenci[] dizi1 = {ogrenci, ogrenci2,ogrenci3};
Ogrenci[] dizi2 = new Ogrenci[3];
dizi2[0] = ogrenci;
dizi2[1] = ogrenci2;
dizi2[2] = ogrenci3;
foreach(Ogrenci d in dizi2)
    Console.WriteLine($"{d.ad} {d.no} {d.sube}");
for(int i=0;i<dizi2.Length;i++)
    Console.WriteLine($"{dizi2[i].ad} {dizi2[i].no} {dizi2[i].sube}");

Console.Write("Miktar:");
int miktar = int.Parse(Console.ReadLine());
Urun[] urunler=new Urun[miktar];
int fiyat;
string ad, aciklama;
for(int i=0;i<urunler.Length;i++)
{
    Console.WriteLine((i + 1) + ".urun:");
    Console.Write("Ad:");
    ad=Console.ReadLine();
    Console.Write("Fiyat:");
    fiyat = int.Parse(Console.ReadLine());
    Console.Write("Açıklama:");
    aciklama = Console.ReadLine();
    Urun urun = new Urun()
    {
        ad = ad,
        fiyat = fiyat,
        aciklama = aciklama
    };
    urunler[i] = urun;
}
foreach (Urun urun in urunler)
    Console.WriteLine(urun.ad + "\t" + urun.fiyat + "\t\t" + urun.aciklama);

