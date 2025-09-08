using Microsoft.EntityFrameworkCore;
using Toy_Store.Models;

namespace Toy_Store.Data
{
    public class DBContext:DbContext
    {
        IConfiguration appConfig;

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }




        public DBContext(IConfiguration config)
        {
            appConfig = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(appConfig.GetConnectionString("DefaultConnection"));
        }
    }
}
