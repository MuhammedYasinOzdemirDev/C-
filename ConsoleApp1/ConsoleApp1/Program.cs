using ConsoleApp1;
using MyS
Console.WriteLine();
ShopContext db = new ShopContext();

    var p = new Product();
    p.Name = "s";
    p.Price= 100;
    db.Products.Add(p);
   db.SaveChanges();
