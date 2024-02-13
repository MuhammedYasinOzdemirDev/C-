using Constructor__Yapıcı_Metodlar_;
using System.Reflection;

Araba araba=new Araba()
{
    marka="Mercedes",model="benz",renk="beyaz",otomatik=true
};//paremetresi constroctur
Araba araba1 = new Araba("Mercedes", "benz", "beyaz",  true);//paremetrerli
Araba araba2 = new Araba("Mercedes", "benz", "beyaz", true, 60);//overloaiding hali
Console.WriteLine(araba2.marka);
var prodouct = new Product();
Console.WriteLine(prodouct.id);
var prodouct2 = new Product(5555);
Console.WriteLine(prodouct2.id);
var prodouct3 = new Product("Yasin",15555);
Console.WriteLine(prodouct3.id);
Yorumlar yorumlar = new Yorumlar("Merhaba");
Yorumlar yorumlar1 = new Yorumlar("Naber");
Yorumlar yorumlar2 = new Yorumlar("Napıyorsun");
prodouct3.yorumlar[0] = yorumlar;
prodouct3.yorumlar[1] = yorumlar1;
prodouct3.yorumlar[2] = yorumlar2;
Console.WriteLine(prodouct3.id + "\t" + prodouct3.name + "\t" + prodouct3.fiyat);
for (int i = 0; i < 3; i++)
    Console.WriteLine(prodouct3.yorumlar[i].id + "\t" + prodouct3.yorumlar[i].text);