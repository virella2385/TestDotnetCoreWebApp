using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestNetCoreWebApp.Models;
//using System.Collections;

namespace TestNetCoreWebApp.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private TestDotnetCoreWebAppDbContext _context;
        
        public SqlRestaurantData (TestDotnetCoreWebAppDbContext context) 
        {
          _context = context;
        }

    public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.id);
        }

        public Restaurant Get(int id) 
        {
            return _context.Restaurants.FirstOrDefault(r => r.id == id);
        }

        public Restaurant Add(Restaurant restaurant) 
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Update(Restaurant restaurant) 
        {
            _context.Restaurants.Attach(restaurant).State = EntityState.Modified;;
            _context.SaveChanges();
            return restaurant;
        }

    }
}