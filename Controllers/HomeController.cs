using Microsoft.AspNetCore.Mvc;
using TestNetCoreWebApp.Models;
using TestNetCoreWebApp.Services;

namespace TestNetCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
    	private IRestaurantData _restaurantData;
    	public HomeController(IRestaurantData restarantData)
    	{
    		_restaurantData = restarantData;
    	}
        public IActionResult Index()
        {
        	 var result = _restaurantData.GetAll();
            return View(result);

        }
    }
}