using Properties;
Product product = new Product();
product.fiyat = -500;//set metodu çalışır 0 atanır
Console.WriteLine(product.fiyat);//get çalışır 0 yazar
product.fiyat = 500;//set metodu çalışır 500 atanır
Console.WriteLine(product.fiyat);//get çalışır 500 yazar
product.name = "";//hata mesajı verir set calisir
product.name = "affa";//;deger atanir
Console.WriteLine(product.durum);//durumu ogrenir
//product.durum = false; bu kod hatalı set kodu yok baska metodla erişimeli

