using Microsoft.AspNetCore.Mvc;
using TestNetCoreWebApp.Services;

namespace TestNetCoreWebApp.ViewComponents
{
    public class GreeterViewComponent : ViewComponent
    {
        private IGreeter _greeter;
        public GreeterViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetMessageOfTheDay();
            return View("Default", model);
        }
    }
}