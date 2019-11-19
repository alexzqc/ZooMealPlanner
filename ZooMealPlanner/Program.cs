using System;

namespace ZooMealPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m = new Mammal();

            while (true)
            {
                Console.WriteLine("======================================");
                Console.WriteLine();
                Console.WriteLine("Zoo Menu Planner");
                Console.WriteLine();
                Console.WriteLine("======================================");
                Console.WriteLine("1. Monkey");
                Console.WriteLine();
                Console.WriteLine("2. Bear");
                Console.WriteLine();
                Console.WriteLine("3. Quit");
                Console.WriteLine();
                Console.WriteLine("Selection:");
                Console.WriteLine();
                double sel1 = Convert.ToDouble(Console.ReadLine());

                if (sel1 == 1)
                {
                    Console.WriteLine(m.Mam1);
                    continue;
                }
                else
                if (sel1 == 2)
                {
                    Console.WriteLine(m.Mam2);
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
