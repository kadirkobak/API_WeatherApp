using API_WeatherApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_WeatherApp.Context
{
    public class WeatherContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=1LP021\\SQLEXPRESS;initial catalog=WeatherApiApp;integrated security=true;TrustServerCertificate=true");
        }

        public DbSet<City> Cities { get; set; }

    }
}
