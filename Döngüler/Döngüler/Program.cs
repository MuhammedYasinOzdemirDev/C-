//for döngüsü
for (int i = 0; i < 10; i++)//degisken ve degerleri;kosul;her dongude yapılacak islemler
    Console.Write(i + "  ");
Console.WriteLine();
for (int i = 9; i >=0; i--)//azalan dongu
    Console.Write(i + "  ");
//Baslangic,bitis,ve art,s degerine gore sayilari yazdirma
Console.WriteLine();
Console.Write("Baslangic:");
int bas=int.Parse(Console.ReadLine());
Console.Write("Bitis:");
int bitis = int.Parse(Console.ReadLine());
Console.Write("Artış:");
int artis = int.Parse(Console.ReadLine());
for(int i=bas;i<=bitis;i+=artis)
    Console.Write(i + "  ");
//1 den 100 kadar 6 katı olanları yazdirma
Console.WriteLine();
for (int i = 1; i < 100; i++)
{
    if (i % 6 == 0)
        Console.Write(i + "  ");
}
int[] dizi = { 1, 4, 5, 8, 6, 5, 11, 456, 8, 2, 24, 2 };//sayilarin toplam nedir
int t = 0;
for (int i = 0; i<dizi.Length; i++)
    t += dizi[i];
Console.WriteLine("Toplam:" + t);
//dizideki tek sayilarin karesini ekrana yazdırma
for(int i=0;i<dizi.Length;i++)
{
    if(i%2==1)
        Console.Write(i*i + "  ");
}
string[] arabalar = { "Mercedes", "BMW", "Toyata", "Mazda", "Hyundia", "Lamborghni", "Ford" };
//arabalar dizisindeki en az 5 karekterli olanlari yazdirma
for(int i=0;i<arabalar.Length; i++)
{
    if (arabalar[i].Length>=5)
        Console.WriteLine(arabalar[i]);
}
//While
int j = 0;
while (j< 10)
{
    if (j % 2 == 0)
        Console.WriteLine(j + " çift");
    else
        Console.WriteLine(j + " tek");
    j++;
}
string name = "";
while (string.IsNullOrEmpty(name))//string içinde null veya bosluk olana kadar devam eder

{
    Console.Write("name:");
    name=Console.ReadLine();

}
//uygulama
Console.Write("Adet");
int adet=int.Parse(Console.ReadLine());
string[] urunler = new string[adet];
 int z = 0;
do
{
    Console.Write((z + 1) + ".urun:");
    urunler[z] = Console.ReadLine();
    z++;
} while (z != adet);
z = 0;
while (z != adet)
{
    Console.WriteLine((z + 1) + ".urun:" + urunler[z]);
    z++;
}
//asal kontrol
bool asalmi = true;
for(int i = 2; i < 100; i++)
{
    asalmi = false;
    for( j=2; j<(i/2); j++)
    {
        if(i%j==0)
        {
            asalmi = false;
            break;
        }
    }
    if (asalmi)
        Console.WriteLine(i + " sayisi asaldir");
    else
        Console.WriteLine(i + " sayisi asal degildir");
}