using System.Globalization;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);
Console.WriteLine(dt.Year);
Console.WriteLine(dt.Month);
Console.WriteLine(dt.Day);
Console.WriteLine(dt.Hour);
Console.WriteLine(dt.Minute);
Console.WriteLine(dt.Second);
Console.WriteLine(dt.DayOfWeek);//haftanin kaçinci gunu bulur
DateTime dt2 = new DateTime(2003,7,18,10,30,5);//tarih olsuturma
DateTime dt1 = dt.AddDays(2);//2 gun ekler
dt1= dt1.AddMonths(3);//3 ay ekler
dt1= dt1.AddYears(-2);//2 yil cikarir
var fark = dt - dt1;//farkı alır Timespace objesi
Console.WriteLine(fark.TotalDays);//tarihler arasi gun farkini bulur
Console.WriteLine(fark.TotalHours);//saat farkini bulur
//Datetime formatlar
Console.WriteLine(dt.ToString("d"));//kisa tarih formati
Console.WriteLine(dt.ToString("D"));//uzun tarih formatinda yazar
Console.WriteLine(dt.ToString("F"));//TAm uzun tarih saat
Console.WriteLine(dt.ToString("M"));//ayın gününü yazar
Console.WriteLine(dt.ToString("t"));//kısa saati yazar
Console.WriteLine(dt.ToString("T"));//Uzun saati yazar
//Kendi Formatında Datetime Ayaralama
Console.WriteLine(dt.ToString("hh:mm:ss"));//saat ay saniye formati
Console.WriteLine(dt.ToString("Saat:hh:mm:ss"));
Console.WriteLine(dt.ToString("ddd MMM %d, yyyy"));

CultureInfo cl=new CultureInfo("en-US");//ingiliz kulturu tanimlar
Console.WriteLine(dt.ToString("F", cl));//F formatinda cl kultunde tarih yazar
