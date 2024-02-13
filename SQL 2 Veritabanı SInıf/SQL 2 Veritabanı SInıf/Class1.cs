using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQL_2_Veritabanı_SInıf
{
     class Product
    {
        public Product(int id, string name, double price)
        {
            this.ProductId = id;
            this.Name = name;
            this.Price = price;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
     
    class MySqlProductDalll
    {
         MySqlConnection GetMySqlConnection()
        {
            string connectionstring = @"server=localhost;port=3306;database=northwind;user=root;password=12345";
            return new MySqlConnection(connectionstring);
        }
        public void Create(Product p)
        {
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("Insert into products (product_name,list_price,discontinued) values(@name,@price,@dis)", connection);
                    command.Parameters.AddWithValue("@name", p.Name);
                    command.Parameters.AddWithValue("@price", p.Price);
                    command.Parameters.AddWithValue("@dis",1);
                    int result = command.ExecuteNonQuery();//komutu işler kaç komut işlediyse dondurur
                    Console.WriteLine($"{result} kayıt eklendi...");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            
            }

        }

        public void Delete(int id)
        {
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("Delete from products where id=@id", connection);
                 
                    command.Parameters.AddWithValue("@id", id);
                    int result = command.ExecuteNonQuery();//komutu işler kaç komut işlediyse dondurur
                    Console.WriteLine($"{result} kayıt silindi...");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public List<Product> Find(string name)
        {
            List<Product> products = null; ;
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("select * from products where product_name like @name", connection);
                    command.Parameters.Add("@name", MySqlDbType.String).Value="%"+name+"%";//parametreleri @ işareti ile girerirz
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();//tek bir kez okur
                    products = new List<Product>();
                    while (reader.Read())
                    {
                        products.Add(new Product(int.Parse(reader["id"].ToString()), reader["product_name"].ToString(), double.Parse(reader["list_price"].ToString())));
          

                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
                return products;
            }
        }

        public int count()
        {
            int c = 0;
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("select count(*) from products", connection);
                    object a=command.ExecuteScalar();//okuma yonetmeidir reader da yapılabilir fakat int olarak tek deger varsa scalar mantılı
                    if (a != null)
                    {
                        c = Convert.ToInt32(a);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return c;

        }
        public List<Product> GetAllProducts()
        {
            List<Product> products = null;
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Bağlantı Başarılı");
                    string sorgu = "select * from products";
                    MySqlCommand command = new MySqlCommand(sorgu, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    products = new List<Product>();
                    while (reader.Read())
                    {
                        products.Add(new Product(int.Parse(reader["id"].ToString()), reader["product_name"].ToString(), double.Parse(reader["list_price"].ToString())));
                        Console.WriteLine($"name:{reader[3]} price:{reader[6]}");

                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
                return products;
            }
        }

        public Product GetProductById(int id)
        {
            Product product = null;
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("select * from products where id=@id",connection);
                    command.Parameters.Add("@id",MySqlDbType.Int32).Value=id;//parametreleri @ işareti ile girerirz
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();//tek bir kez okur
                    if (reader.HasRows)//kayıt varmı kontrol
                    {
                        product=new Product(int.Parse(reader["id"].ToString()), reader["product_name"].ToString(), double.Parse(reader["list_price"].ToString()));
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
                return product;
            }
        }

        public void Update(Product p)
        {
            using (var connection = GetMySqlConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("Update products Set product_name=@name ,list_price=@price where id=@id", connection);
                    command.Parameters.AddWithValue("@name", p.Name);
                    command.Parameters.AddWithValue("@price", p.Price);
                    command.Parameters.AddWithValue("@id", p.ProductId);
                    int result = command.ExecuteNonQuery();//komutu işler kaç komut işlediyse dondurur
                    Console.WriteLine($"{result} kayıt guncellendi...");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }
    }
}
