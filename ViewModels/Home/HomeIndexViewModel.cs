using System.Collections.Generic;
using TestNetCoreWebApp.Models;

namespace TestNetCoreWebApp.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> restaurants { get; set; }
        public string currentMessage { get; set; }
    }
}