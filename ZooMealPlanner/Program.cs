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
                    if (sel3 == 1 || sel3 == 2 || sel3 == 3)
                    {

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
