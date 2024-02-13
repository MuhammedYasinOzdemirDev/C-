using SQL_2_Veritabanı_SInıf;

MySqlProductDalll mySqlProductDal=new MySqlProductDalll();
var product=mySqlProductDal.GetProductById(4);
Console.WriteLine($"{product.Name} {product.Price}");
var products = mySqlProductDal.Find("Northwind");
foreach(var productt in products)
    Console.WriteLine($"{productt.Name} {productt.Price}");
Console.WriteLine("count:"+mySqlProductDal.count());
mySqlProductDal.Create(new Product(4, "skd", 54894));
mySqlProductDal.Update(new Product( 14, "Muhammmed",  65996 ));
 product = mySqlProductDal.GetProductById(14);
Console.WriteLine($"{product.Name} {product.Price}");
mySqlProductDal.Delete(106);
