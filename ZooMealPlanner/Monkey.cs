using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    class Monkey: Mammal
    {
        public Monkey(double servingRatio, string species) : base(servingRatio, species)
        {
            FoodPreference = "fresh fruit, vegetables, nuts, insects, berries";
            FeedTime = "9AM, 12PM and 5PM";
            Type = "Monkey";
        }
    }
}
