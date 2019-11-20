using System;

namespace ZooMealPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m = new Mammal();
            Bears b = new Bears();
            Monkey monkey = new Monkey();
            AllAnimals allAnimals = new AllAnimals();

            while (true)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("Zoo Menu Planner");
                Console.WriteLine("======================================");
                Console.WriteLine();
                Console.WriteLine($"1. {allAnimals.AllInstruction[2,0]}");
                Console.WriteLine($"2. {allAnimals.AllInstruction[0,0]}");
                Console.WriteLine("3. Quit");
                Console.WriteLine();
                Console.WriteLine("Selection:");
                
                double sel1 = Convert.ToDouble(Console.ReadLine());

                if (sel1 == 1)
                {
                    Console.WriteLine("Species");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"1. {allAnimals.AllInstruction[2, 1]}");
                    Console.WriteLine($"2. {allAnimals.AllInstruction[3, 1]}");
                    Console.WriteLine($"3. {allAnimals.AllInstruction[4, 1]}");
                    Console.WriteLine();
                    Console.WriteLine("Selection:");
                    double sel2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Weight in KG:");
                    double oprand1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Meal Recommendation");
                    Console.WriteLine("--------------------------------------");
                    if (sel2 == 1||sel2 ==2||sel2==3)
                    {
                        if (sel2 == 1)
                        {
                            double serve = oprand1 * Convert.ToDouble(allAnimals.AllInstruction[2, 2]);
                            string serveString = serve.ToString("0.000");
                            string oprand1String = oprand1.ToString("F");
                            Console.WriteLine($"Mammal Type:  {allAnimals.AllInstruction[2, 0]}");
                            Console.WriteLine($"Species:      {allAnimals.AllInstruction[2, 1]}");
                            Console.WriteLine($"Weight:       {oprand1String}KG");
                            Console.WriteLine($"Serving:      {serveString}KG {allAnimals.AllInstruction[2, 3]}");
                            Console.WriteLine("Instructions: Keep area secure at all times.");
                            Console.WriteLine($"              Feed at {allAnimals.AllInstruction[2, 4]}");
                        }else
                        if (sel2 == 2)
                        {
                            double serve1 = oprand1 * Convert.ToDouble(allAnimals.AllInstruction[3, 2]);
                            string serveString1 = serve1.ToString("0.000");
                            string oprand1String = oprand1.ToString("F");
                            Console.WriteLine($"Mammal Type:  {allAnimals.AllInstruction[3, 0]}");
                            Console.WriteLine($"Species:      {allAnimals.AllInstruction[3, 1]}");
                            Console.WriteLine($"Weight:       {oprand1String}KG");
                            Console.WriteLine($"Serving:      {serveString1}KG {allAnimals.AllInstruction[3, 3]}");
                            Console.WriteLine("Instructions: Keep area secure at all times.");
                            Console.WriteLine($"              Feed at {allAnimals.AllInstruction[3, 4]}");
                        }
                        else
                        {
                            double serve2 = oprand1 * Convert.ToDouble(allAnimals.AllInstruction[4, 2]);
                            string serveString2 = serve2.ToString("0.000");
                            string oprand1String = oprand1.ToString("F");
                            Console.WriteLine($"Mammal Type:  {allAnimals.AllInstruction[4, 0]}");
                            Console.WriteLine($"Species:      {allAnimals.AllInstruction[4, 1]}");
                            Console.WriteLine($"Weight:       {oprand1String}KG");
                            Console.WriteLine($"Serving:      {serveString2}KG {allAnimals.AllInstruction[4, 3]}");
                            Console.WriteLine("Instructions: Keep area secure at all times.");
                            Console.WriteLine($"              Feed at {allAnimals.AllInstruction[4, 4]}");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Wrong Input, please select again");
                        continue;
                    }

                    continue;
                }
                else
                if (sel1 == 2)
                {
                    Console.WriteLine("Species");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"1. {allAnimals.AllInstruction[0, 1]}");
                    Console.WriteLine($"2. {allAnimals.AllInstruction[1, 1]}");
                    Console.WriteLine();
                    Console.WriteLine("Selection:");
                    double sel3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Weight in KG:");
                    double oprand2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Meal Recommendation");
                    Console.WriteLine("--------------------------------------");
                    if (sel3 == 1 || sel3 == 2)
                    {
                        if (sel3 == 1)
                        {
                            double serve3 = oprand2 * Convert.ToDouble(allAnimals.AllInstruction[0, 2]);
                            string serveString3 = serve3.ToString("0.000");
                            string oprand1String = oprand2.ToString("F");
                            Console.WriteLine($"Mammal Type:  {allAnimals.AllInstruction[0, 0]}");
                            Console.WriteLine($"Species:      {allAnimals.AllInstruction[0, 1]}");
                            Console.WriteLine($"Weight:       {oprand1String}KG");
                            Console.WriteLine($"Serving:      {serveString3}KG {allAnimals.AllInstruction[0, 3]}");
                            Console.WriteLine("Instructions: Keep area secure at all times.");
                            Console.WriteLine($"              Feed at {allAnimals.AllInstruction[0, 4]}");
                        }
                        else
                        {
                            double serve3 = oprand2 * Convert.ToDouble(allAnimals.AllInstruction[1, 2]);
                            string serveString3 = serve3.ToString("0.000");
                            string oprand1String = oprand2.ToString("F");
                            Console.WriteLine($"Mammal Type:  {allAnimals.AllInstruction[1, 0]}");
                            Console.WriteLine($"Species:      {allAnimals.AllInstruction[1, 1]}");
                            Console.WriteLine($"Weight:       {oprand1String}KG");
                            Console.WriteLine($"Serving:      {serveString3}KG {allAnimals.AllInstruction[1, 3]}");
                            Console.WriteLine("Instructions: Keep area secure at all times.");
                            Console.WriteLine($"              Feed at {allAnimals.AllInstruction[1, 4]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input, please select again");
                        continue;
                    }
                    continue;
                }
                else
                if (sel1 == 3)
                { 
                    break; 
                }
                else
                {
                    Console.WriteLine("Wrong Input, please select again");
                    continue;
                }
            }

        }

        
    }
}
