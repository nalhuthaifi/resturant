using Microsoft.EntityFrameworkCore;
using Restaurant.Domain;



namespace Restaurant.Data
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Type> Type { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog=RestaurantAppData");

        }

    }
}
