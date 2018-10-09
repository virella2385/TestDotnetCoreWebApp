using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestNetCoreWebApp.Models;
using TestNetCoreWebApp.Services;

namespace TestNetCoreWebApp.Pages.Restaurants
{
    public class EditModel : PageModel
    {
    	[BindPropertyAttribute]
        public Restaurant restaurant { get; set; }
        private IRestaurantData _data;

        public EditModel(IRestaurantData data)
        {
            _data = data;
        }

        public IActionResult OnGet(int id)
        {
            restaurant = _data.Get(id);
            if (restaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }

        public IActionResult OnPost() 
        {
        	if (ModelState.IsValid)
        	{
        		_data.Update(restaurant);
        		return RedirectToAction("Details", "Home", new { id = restaurant.id });
        	}
        	return Page();
        }
    }
}