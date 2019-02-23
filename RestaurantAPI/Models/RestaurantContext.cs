using Microsoft.EntityFrameworkCore;

namespace RestaurantAPI.Models
{
    public class RestaurantContext:DbContext
    {
         public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=RestaurantDB;Username=postgres;Password=psql123");
    }

    public class Restaurant
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}