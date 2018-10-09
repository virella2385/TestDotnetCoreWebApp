using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestNetCoreWebApp.Models;
using TestNetCoreWebApp.Services;

namespace TestNetCoreWebApp.Pages
{
    public class BaseModel : PageModel
    {
    	private IRestaurantData _sqlRestaurantData;
    	public IEnumerable<Restaurant> restaurants { get; set; }

    	public BaseModel (IRestaurantData sqlRestaurantData) 
    	{
    	  _sqlRestaurantData = sqlRestaurantData;
    	}

        public void OnGet()
        {
            restaurants = _sqlRestaurantData.GetAll();
        }
    }
}