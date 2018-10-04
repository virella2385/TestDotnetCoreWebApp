using Microsoft.AspNetCore.Mvc;
using TestNetCoreWebApp.Models;
using TestNetCoreWebApp.Services;
using TestNetCoreWebApp.ViewModels.Home;
using TestNetCoreWebApp.Views.Home;

namespace TestNetCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;
        public HomeController(IRestaurantData restarantData, IGreeter greeter)
        {
            _restaurantData = restarantData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {
            HomeIndexViewModel result = new HomeIndexViewModel();
            result.restaurants = _restaurantData.GetAll();
            result.currentMessage = _greeter.GetMessageOfTheDay();
            return View(result);
        }

        public IActionResult Details(int id)
        {
            var result = _restaurantData.Get(id);
            if (result == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditModel restaurant)
        {
        	Restaurant newRestaurant = new Restaurant();
        	newRestaurant.name = restaurant.name;
        	newRestaurant.cuisine = restaurant.cuisine;

        	newRestaurant = _restaurantData.Add(newRestaurant);
            return View("Details", newRestaurant);
        }
    }
}