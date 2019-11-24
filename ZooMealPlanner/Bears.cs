﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    class Bears: Mammal
    {
        public Bears(string foodPreference, double servingRatio, string species) : base(servingRatio, species)
        {
            FoodPreference = foodPreference;
            Type = "Bear";
            FeedTime = "9AM and 3PM";
        }
    }
}
