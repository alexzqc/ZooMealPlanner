using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    class AllAnimals : Mammal
    {
        public string[,] AllInstruction = new string[5, 5];
        public AllAnimals()
        {
            this.AllInstruction = new string[,]{
                { "Bear","Black","0.014","berries, green vegetation, flowers, fruits, fish","9AM and 3PM"},
                { "Bear","Polar","0.016","berries, fish","9AM and 3PM" },
                { "Monkey","Squirrel","0.006","fresh fruit, vegetables, nuts, insects, berries","9AM, 12PM and 5PM." },
                { "Monkey","Howler","0.007","fresh fruit, vegetables, nuts, insects, berries","9AM, 12PM and 5PM." },
                { "Monkey","Colobus","0.008","fresh fruit, vegetables, nuts, insects, berries","9AM, 12PM and 5PM." },
            };
        }
    }
}
