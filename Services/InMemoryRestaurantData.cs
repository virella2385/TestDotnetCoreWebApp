using System.Collections.Generic;
using System.Linq;
using TestNetCoreWebApp.Models;

namespace TestNetCoreWebApp.Services
{

    /*public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { id = 1, name = "Virellas"},
                new Restaurant { id = 2, name = "Rodrigues"},
                new Restaurant { id = 3, name = "Maldonados"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.id);
        }

        public Restaurant Get(int id) 
        {
            return _restaurants.FirstOrDefault(r => r.id == id);
        }

        public Restaurant Add(Restaurant restaurant) 
        {
            // Since it's in memory data, for the time being I'll generate the new id like so ...
            restaurant.id = _restaurants.Max(r => r.id) + 1;
            _restaurants.Add(restaurant);
            return restaurant;
        }

    }*/
}