// See https://aka.ms/new-console-template for more information
Console.Write("1 Sayı:");
string temp=Console.ReadLine();
int s1=int.Parse(temp);
Console.Write("2 Sayı:");
temp=Console.ReadLine();
int s2=Convert.ToInt32(temp);
int toplam = s1 + s2;
Console.WriteLine($"Toplam:{toplam}");

Console.Write("Kısa Kenar: ");
int kisa=int.Parse(Console.ReadLine());
Console.Write("Uzun Kenar: ");
int uzun=int.Parse(Console.ReadLine());

var alan = kisa * uzun;//değişken turune gore değişir
var cevre = 2 * kisa + 2 * uzun;
Console.WriteLine($"Alan:{alan} Cevre:{cevre}");

