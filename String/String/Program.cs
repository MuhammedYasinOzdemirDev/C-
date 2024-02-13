Console.Write("Ad: ");
String name=Console.ReadLine();
Console.Write("Soyad: ");
string soyad=Console.ReadLine();
Console.Write("Yas: ");
int yas=int.Parse(Console.ReadLine());

string str1 = "My name is " + name + " " + soyad+" and I'm "+yas+" years";
string str2 = string.Format("My name is {0} {1} and I'm {2} years",name,soyad,yas);
string str3 = $"My name is {name} {soyad} and I'm {yas} years";
Console.WriteLine(str1);
Console.WriteLine(str2);    
Console.WriteLine(str3);

//Metodları
String msg = " Merhaba Dünya  ";
Console.WriteLine(msg);
Console.WriteLine(msg.Length);//uzunluk bulur
Console.WriteLine(msg.ToLower());//hepsini kucuk yapar
Console.WriteLine(msg.ToUpper());//hepsini buyuk yapar
Console.WriteLine(msg.Trim());//etrafında boslukları siler
Console.WriteLine(msg.Split());//girilen degere gore veya default bosluk olan dizi olusturur
Console.WriteLine(msg[1]);//1 indise erisir
Console.WriteLine(msg.Trim().StartsWith("Me"));//baslangici kontrol eder bool doner
Console.WriteLine(msg.EndsWith("m"));
Console.WriteLine(msg.Contains("Dünya"));//içinde varmı kontrol eder
Console.WriteLine(msg.IndexOf("Dünya"));//indexi bulur
Console.WriteLine(msg.Substring(5));//5 indisten sona kadar yazdirir
Console.WriteLine(msg.Substring(4,3));//4 indisten 3 kez yazdirir
Console.WriteLine(msg.Insert(0,"......"));//eleman ekler indise
Console.WriteLine(msg.Remove(4));//4 indisten itibaren siler
Console.WriteLine(msg.Remove(2,3));//2 indisten 3 kez yazar



