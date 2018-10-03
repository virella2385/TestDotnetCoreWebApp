using System.Collections.Generic;
using TestNetCoreWebApp.Models;

namespace TestNetCoreWebApp.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}