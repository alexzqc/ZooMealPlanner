using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    class Monkey: Mammal
    {
       // Monkey class, get servingRatio, species from parent class
        public Monkey(double servingRatio, string species) : base(servingRatio, species)
        {
            FoodPreference = "fresh fruit, vegetables, nuts, insects, berries";
            FeedTime = "9AM, 12PM and 5PM";
            Type = "Monkey";
        }
    }
}
