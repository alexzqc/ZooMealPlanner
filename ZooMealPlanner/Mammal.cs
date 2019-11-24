using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    public abstract class Mammal
    {
        protected string Type;
        protected string Species;
        protected double ServingRatio;
        protected string FoodPreference;
        protected string FeedTime;

        protected Mammal(double servingRatio, string species)
        {
            ServingRatio = servingRatio;
            Species = species;
        }

        public void printdetails(double inputweight)
        {
            Console.WriteLine($"Mammal Type:  {Type}");
            Console.WriteLine($"Species:      {Species}");
            Console.WriteLine($"Weight:       {inputweight}KG");
            Console.WriteLine($"Serving:      {ServingRatio * inputweight}KG {FoodPreference}");
            Console.WriteLine("Instructions: Keep area secure at all times.");
            Console.WriteLine($"              Feed at {FeedTime}");
            
        }

    }
}
