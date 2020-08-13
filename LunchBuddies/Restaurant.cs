using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        private List<string> RestaurantNames = new List<string> { "McDonald's", "Subway", "Arby's" };
        
        public string Name { get; set; }

        public Restaurant()
        {
            Random rnd = new Random();
            Name = RestaurantNames[rnd.Next(RestaurantNames.Count)];
        }
    }
}
