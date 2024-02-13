//Hata Yönetimi (Exception)

/*int a = int.Parse(Console.ReadLine());//System.FormatException hatası
int b = int.Parse(Console.ReadLine());
var sonuc = a / b;//System.DivideByZeroException 0 ise bolen hata alır
int[] sayilar = new int[2];
sayilar[4] = 2;System.IndexOutOfRangeException
Product p=null;
Console.WriteLine(p.name);//System.NullReferenceException*/
using Hata_Yönetimi;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("a:");
            int b = int.Parse(Console.ReadLine());
            var sonuc = a / b;
            Console.WriteLine(a + " / " + b + " = " + sonuc);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("b sıfır olmaz...");
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Lütfen uygun formatta giriniz...");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata olustu");
            Console.WriteLine(ex.Message);
        }
        finally { Console.WriteLine("Finally çalıştı..."); }

        //Hata fırlatma
        int sayi = 10;
        try
        {
            if (sayi < 5)
                throw new Exception("Sayı 5 den buyuk olmaz...");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        void check_passaword(string passaword)
        {
            if (passaword.Length < 7 || passaword.Length > 15)
                throw new Exception("Paralo 7-15 arası olmalı...");
            if (!passaword.Any(char.IsDigit))//isdigit sayı yokmu hiç sorusudur 
                throw new Exception("Parolo en az bir rakam içermelidir");
            if (!passaword.Any(char.IsLetter))
                throw new Exception("Paralo en az bir harf olamalıdır...");
            if (string.IsNullOrEmpty(passaword))
                throw new Exception("Paralo bos veya null olamaz");
        }
        while (true)
        {
            Console.Write("Paralo:");
            string p = Console.ReadLine();
            if (p == "q")
                break;
            else
            {
                try
                {
                    check_passaword(p);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        Product product = new Product();
        while (true)
        {
            try
            {
                Console.Write("Id:");
                product.Id = int.Parse(Console.ReadLine());
                Console.Write("Name:");
                product.Name = Console.ReadLine();
                Console.Write("Kontrol:");
                var kontrol = Console.ReadLine();
                if (kontrol == "q")
                    break;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        //listedeki sayısala degerleri bulunuz
        ArrayList list = new ArrayList() { "1", "2", "5a", "10b", "abc", "10", "50" };
        foreach (var i in list)
        {
            try
            {
                Convert.ToInt16(i);
                Console.WriteLine(i + " Sayıdır...");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(i + " Sayı değildir");
            }
        }
        //q harfi olmadıkça girilen sayımı kontrol eden uygulama
        while (true)
        {
            var s = Console.ReadLine();
            try
            {
                if (s == "q")
                    break;
                int.Parse(s);
                Console.WriteLine(s + " sayıdır");
            }
            catch (FormatException)
            {
                Console.WriteLine(s + " sayı değildir...");
            }
        }
        //Girilen Paraloda türkçe karekter araması yapınız
        void CheckPassaword(string passaword)
        {
            string turkce_karekterler = "ğ,Ğ,ü,Ü,ç,Ç,ş,Ş,ö,Ö,ı,İ";
            foreach (var k in passaword)
            {
                if (turkce_karekterler.IndexOf(k) > -1)
                    throw new Exception("Paralo turkçe karekter içerir...");
            }
        }
        while (true)
        {
            var s = Console.ReadLine();
            try
            {
                if (s == "q")
                    break;
                CheckPassaword(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       /* static void Login(string username, string password)
        {
         
                if (username.Contains(" "))
                    throw new LoginException("username bosluk içeremez");
                if (password.Length < 7)
                    throw new LoginException("Password 7 karekteden az olamaz");
           
        }*/
    }
}