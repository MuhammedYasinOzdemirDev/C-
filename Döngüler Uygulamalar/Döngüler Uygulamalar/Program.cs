//Sayi Tahmin Oyunu
int hak = 10,tahmin;
Random random = new Random();
int sayi = random.Next(100);

while (hak != 0)
{
    Console.Write((11 - hak) + ".tahmin:");
    tahmin = int.Parse(Console.ReadLine());
    if (tahmin > sayi)
        Console.WriteLine("Daha kucuk sayi giriniz");
    else if (tahmin < sayi)
        Console.WriteLine("Daha buyuk sayi giriniz");
    else
    {
        Console.WriteLine("Tebrikler bildiniz...");
        break;
    }
    hak--;
}
if (hak == 0)
    Console.WriteLine("Kaybettiniz...");

//Bankamatik
string menu = "\n\t1.Bakiye\n\t2.Para Yatırma\n\t3.Para Çekme\n\t4.Çıkış\nsecim:";
int secim,bakiye=5000,temp;
while (true)
{
    Console.Write(menu);
    secim = int.Parse(Console.ReadLine());
    if (secim == 1)
        Console.WriteLine("Bakiye:" + bakiye);
    else if (secim == 2)
    {
        Console.Write("Miktar:");
        temp = int.Parse(Console.ReadLine());
        bakiye += temp;
        Console.WriteLine("Para Yatırıldı...");
    }
    else if (secim == 3)
    {
        Console.Write("Miktar:");
        temp = int.Parse(Console.ReadLine());
        if (temp < bakiye && temp > 0)
        {
            bakiye -= temp;
            Console.WriteLine("Para Cekildi...");
        }
        else
            Console.WriteLine("Yetersiz Bakiye...");
    }
    else if (secim == 4)
        break;
    else
        Console.WriteLine("Hatali kodlama...");
}