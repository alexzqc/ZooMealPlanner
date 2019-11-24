using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    public abstract class Mammal
    { //the parent class
        protected string Type;
        protected string Species;
        protected double ServingRatio;
        protected string FoodPreference;
        protected string FeedTime;

        //parent constructor
        protected Mammal(double servingRatio, string species)
        {
            ServingRatio = servingRatio;
            Species = species;
        }

        //the final outout function
        public void printdetails(double inputWeight)
        {
            string inputWeightString = inputWeight.ToString("F");//adjustment of number of digits
            double servingKg = ServingRatio * inputWeight;//calculation of serving amount
            string servingKgString = servingKg.ToString("0.000");//adjustment of number of digits

            Console.WriteLine($"Mammal Type:  {Type}");
            Console.WriteLine($"Species:      {Species}");
            Console.WriteLine($"Weight:       {inputWeightString}KG");
            Console.WriteLine($"Serving:      {servingKgString}KG {FoodPreference}");
            Console.WriteLine("Instructions: Keep area secure at all times.");
            Console.WriteLine($"              Feed at {FeedTime}");
            
        }

    }
}
