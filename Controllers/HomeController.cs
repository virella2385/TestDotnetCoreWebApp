using Microsoft.AspNetCore.Mvc;
using TestNetCoreWebApp.Models;

namespace TestNetCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
        	Restaurant result = new Restaurant { id = 1, name = "Christians" };
            return View(result);

        }
    }
}