

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace ConsoleApp1
{

     class Product
    {
        [Key]//primary key özelliğ verir
        public int Id { get; set; }
        [MaxLength(100)]//max 100 karekter oolmasını sağlar
        [Required]//zorunlu alan olmasını sağlar
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
    class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
       
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=YASIN\SQLEXPRESS;Initial Catalog=BookStoreDb;");
        }
    }
}

