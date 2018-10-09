using System.Collections.Generic;
using TestNetCoreWebApp.Models;

namespace TestNetCoreWebApp.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant restaurant);
    }
}