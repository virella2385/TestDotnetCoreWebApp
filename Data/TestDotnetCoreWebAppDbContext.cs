using Microsoft.EntityFrameworkCore;
using TestNetCoreWebApp.Models;

namespace TestNetCoreWebApp
{
    public class TestDotnetCoreWebAppDbContext : DbContext
    {
        public TestDotnetCoreWebAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}