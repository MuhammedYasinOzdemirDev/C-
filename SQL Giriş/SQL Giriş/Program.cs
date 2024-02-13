using MySql.Data;
using MySql.Data.MySqlClient;
using SQL_Giriş;

static void GetMySqlConnection()
{
    string connectionstring = @"server=localhost;port=3306;database=northwind;user=root;password=12345";
    using (var connection = new MySqlConnection(connectionstring))
    {
        try
        {
            connection.Open();
            Console.WriteLine("Bağlantı Başarılı");
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
static MySqlConnection GetMySqlConnection2()
{
    string connectionstring = @"server=localhost;port=3306;database=northwind;user=root;password=12345";
    return new MySqlConnection(connectionstring);

}
static List<Product> GetAllProducts()
{
    List<Product> list = null;
    using (var connection = GetMySqlConnection2())
        {
            try
            {
                connection.Open();
                Console.WriteLine("Bağlantı Başarılı");
            string sorgu = "select * from products";    
            MySqlCommand command=new MySqlCommand(sorgu,connection);
            MySqlDataReader reader = command.ExecuteReader();
            list = new List<Product>();
            while (reader.Read())
            {
                list.Add(new Product (  int.Parse(reader["id"].ToString()),  reader["product_name"].ToString(), double.Parse(reader["list_price"].ToString())));
                //Console.WriteLine($"name:{reader[3]} price:{reader[6]}");

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
        return list;
    }
}
var products=GetAllProducts();
foreach (var p in products)
    Console.WriteLine($"ID:{p.ProductId}.\nName:{p.Name}\tPrice:{p.Price}\n");
