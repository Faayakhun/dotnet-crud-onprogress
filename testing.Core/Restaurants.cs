using System;
using System.Collections.Generic;
using System.Text;

namespace testing.Core
{
    public enum CuisineType 
    {
        None,
        Mexican,
        Italian,
        Indian
    }
    public class Restaurants
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}