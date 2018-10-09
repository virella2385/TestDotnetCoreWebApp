using System.ComponentModel.DataAnnotations;

namespace TestNetCoreWebApp.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        [DisplayAttribute(Name = "Restaurant Name")]
        [RequiredAttribute, MaxLengthAttribute(80)]
        public string name { get; set; }
        [DisplayAttribute(Name = "Cuisine Type")]
        public CuisineType cuisine { get; set; }
    }
}