using Quiz_Uygulaması_Sınıf;
Soru s1=new Soru("En çok kullanılan programlama dili hangisidir",new string[]{ "Python", "Java", "C#", "Javascript"},"Python");
Soru s2 = new Soru("En popüler programlama dili hangisidir", new string[] { "Python", "Java", "C#", "Javascript" }, "C#");
Soru s3 = new Soru("En çok kazandıran programlama dili hangisidir", new string[] { "Python", "Java", "C#", "Javascript" }, "Javascript");
Soru[] sorular = {s1,s2, s3};
//int i = 1;
/*foreach(var s in sorular)
{
    Console.WriteLine($"{i}.Soru:{s.text}");
    foreach(var cevap in s.cevaplar)
    {
        Console.Write($"{cevap}\t");
    }
    Console.WriteLine();
    Console.Write("Cevap:");
    string cevapp = Console.ReadLine();
    Console.WriteLine(s.kontrol(cevapp) ? "Cevap Doğru..." : "Cevap Yanlış...");
    i++;
}*/
Quiz quiz = new Quiz(sorular);
Quiz quiz1 = new Quiz(s1, s2, s3);//iki kullanımda params dan dolayı gecerli
quiz.ShowSoru();