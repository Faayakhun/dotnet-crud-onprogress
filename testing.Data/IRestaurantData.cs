using System;
using System.Collections.Generic;
using System.Text;
using testing.Core;
using System.Linq;

namespace testing.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurants> GetRestaurantsByName(string name);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurants> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurants>()
            {
                new Restaurants { Id = 1, Name="Fay's Pizza", Location="Bogor", Cuisine=CuisineType.Italian},
                new Restaurants { Id = 2, Name="Ken's Taco", Location="Jakarta", Cuisine=CuisineType.Mexican},
                new Restaurants { Id = 1, Name="Nur's Curry", Location="Purbalingga", Cuisine=CuisineType.Indian} 
            };
        }
        public IEnumerable<Restaurants> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                orderby r.Name
                select r;
        }
    }
}