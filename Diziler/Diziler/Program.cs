// See https://aka.ms/new-console-template for more information
string msg = "Hello there. My name is Muhammed Yasin";
string[] dizi=msg.Split();//string dizi olusturur
for(int i=0; i<dizi.Length; i++)
    Console.WriteLine(dizi[i]);
string[] isimler = new string[3];
string[] isimler2 = new string[] { "Mehmet", "Yasin", "Zeynep", "Selin", "Mustafa" };
isimler[0] = "Mehmet";
isimler[1] = "Mustafa";
isimler[2] = "Zeynep";
int[] dizi2 = new int[5];
Random rand = new Random();
for (int i = 0; dizi2.Length > i; i++)
    dizi2[i] = rand.Next(0,100);
for (int i = 0; dizi2.Length > i; i++)
    Console.Write(dizi2[i]+"  ");
for (int i = 0; i < dizi2.Length; i++)
    Console.WriteLine($"İsim:{isimler2[i]} Numara:{dizi2[i]}");

//metodlar
Console.WriteLine(isimler2.Length);
isimler2.SetValue("Ahmet", 0);//0 indise Ahmet ile değiştirir
Console.WriteLine(isimler2.GetValue(0));//0 indisin degerini alir
Console.WriteLine(Array.IndexOf(isimler2, "Zeynep"));//indisi bulur dizide
Array.Sort(dizi2);//siralar
Array.Reverse(dizi2);//ters çevirir
Array.Clear(dizi2, 0, 2);//0 dan itibaren iki kez siler aslında silmez stringde null int de sifirla degistirir paranetz içinde sadece dizi varssa direk diziyi siler
foreach(var isim in isimler2)//var degiskeni veriye gore degisir
    Console.Write(isim+"\t");
foreach(var isim in isimler2[0..2])//range metodu gibi 0 ve 2 arasini alir
    Console.Write(isim+"\t");
String msg2 = "Merhaba Dünya";
Console.WriteLine();
Console.WriteLine(msg2[1..3]);