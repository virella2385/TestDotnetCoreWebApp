using TestNetCoreWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace TestNetCoreWebApp.Views.Home
{
    public class RestaurantEditModel
    {
    	[RequiredAttribute, MaxLengthAttribute(80)]
        public string name { get; set; }
        public CuisineType cuisine { get; set; }
    }
}