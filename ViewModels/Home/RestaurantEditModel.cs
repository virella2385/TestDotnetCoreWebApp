using TestNetCoreWebApp.Models;

namespace TestNetCoreWebApp.Views.Home
{
    public class RestaurantEditModel
    {
        public string name { get; set; }
        public CuisineType cuisine { get; set; }
    }
}