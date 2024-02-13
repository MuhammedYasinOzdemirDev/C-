//isim yaş,egitim bilgisine gore ehliyet kontrol
string[] isimler = {"Ahmet", "Ayşe", "Mehmet", "Fatma", "Ali", "Zeynep", "Mustafa", "Aysel", "Emre", "Selin",
            "İbrahim", "Elif", "Hüseyin", "Gamze", "Hasan", "Ceren", "Yusuf", "Ebru", "Murat", "Sevgi"};
string[] egitim = { "ilkokul", "ortaokul", "lise", "universite" };
Random rand=new Random();
int yas;
string temp;
for  (int i = 0;i< isimler.Length; i++)
{
    temp = egitim[rand.Next(egitim.Length)];
    yas=rand.Next(7,80);
    if(yas>18 && (temp == "lise" || temp == "universite"))
        Console.WriteLine($"{isimler[i]} ehliyet alabilir");
    else
        Console.WriteLine($"{isimler[i]} ehliyet alamaz");

}
//servis zamanı bakım önceliği hesaplama
Console.Write("Yil: ");
int yil=int.Parse(Console.ReadLine());
Console.Write("Ay: ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Gun: ");
int gun = int.Parse(Console.ReadLine());

int fark = (DateTime.Now - new DateTime(yil, ay, gun)).Days;//gun farkini bulur
if (fark < 365)
    Console.WriteLine("1.Bakım");
else if (fark < 1000)
    Console.WriteLine("2.Bakım");
else
    Console.WriteLine("3.Bakım");
