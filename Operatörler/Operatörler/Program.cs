//Aritmetik Öperatorler
/*int a = 10;
int b = 20;
int val;
val = a + b;//30
val = a - b;//-10
val = a *b;//200
val = a / b;//0
val = b % a;//0
val = a--;//10
val = --a;//9*/

//Atama Opertaorler,
int x = 5, y = 5;
x += 5;
x -= 5;
x *= 5;
x /= 5;
x %= 5;
double val2=Math.Pow(2, 5);
val2= Math.Round(2.5);
Math.Sqrt(25);
x = 5;y = 5;int z = 10;
//Kullanician alınan iki sayi carpiminin x,,z toplamı ile farkı
Console.Write("1-Sayi: ");
int s1 = int.Parse(Console.ReadLine());
Console.Write("2-Sayi: ");
int s2 = int.Parse(Console.ReadLine());
Console.WriteLine(string.Format("Toplam :{0} ikisi farki :{1}", (x + y + z), (s1 + s2) - (x + y + z)));
//Tek cift konrol
Console.Write("Sayi: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine("Sayinin Teklik Durumu" + (s % 2));
//x,y,z toplaminin mod 3 kac
Console.WriteLine("Mod 3: " + ((x + y + z) % 3));
Console.WriteLine("Y nin X kuvveti:" + Math.Pow(y, x));

//KArsilastirma Operatorleri
int a = 5, b = 5, c = 10, d = 4;
var result = (a == b);//true
result = (a == c);//false

String username = "Muhammed";
result = (username == "Muhammed");//true

string resul = (a == b) ? "true ise burası alinir" : "degil ise burasi";

//Mantiksal Operatorler
int e =5;
result = (e > 4) && (e < 10);//true

//Uygulamalar
//1-Girilen iki sayidan hangisi buyuk
s1 = int.Parse(Console.ReadLine());
Console.Write("2-Sayi: ");
s2 = int.Parse(Console.ReadLine());
Console.WriteLine(((s1>s2)?s1:s2)+" Buyuktur");
//2-Parolo ve email kontrol
Console.Write("Email: ");
string email=Console.ReadLine();
Console.Write("Parolo: ");
string parola= Console.ReadLine();
Console.WriteLine("Email:" + ((email == "cozdemir56.yz@gmail.com") ? "Doğru" : "Yanlis") + " Parola:" + ((parola == "12345") ? "Doğru" : "Yanlis"));

