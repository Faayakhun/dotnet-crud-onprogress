using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using testing.Data;
using testing.Core;

namespace testing.Pages.Restaurant
{
    public class ListModel : PageModel 
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        
        public string Message { get; set; }
        public IEnumerable<Restaurants> Restaurant { get; set;}

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet(string searchTerm)
        {
            
            Message = config ["Message"];
            Restaurant = restaurantData.GetRestaurantsByName(searchTerm);
        }
    }
}