using System;
using System.Collections.Generic;
using System.Text;

namespace ZooMealPlanner
{
    class Menu
    {

        //pre-defined parameters
        public int sel1 = 0;
        public int sel2 = 0;
        public double oprand = 0;

        public void ShowMain()
        {
            while (sel1!=1&&sel1!=2&&sel1!=3) {
                Console.WriteLine("======================================");
                Console.WriteLine("Zoo Menu Planner");
                Console.WriteLine("======================================");
                Console.WriteLine();
                Console.WriteLine("1. Monkey");
                Console.WriteLine("2. Bear");
                Console.WriteLine("3. Quit");
                Console.WriteLine();
                Console.WriteLine("Selection:");

                sel1 = Convert.ToInt32(Console.ReadLine());//get first selection here

                if(sel1 !=1&& sel1 != 2&& sel1 != 3)//validator
                {
                    Console.WriteLine("Invalid Input");
                    ShowMain();
                }

            }
        }

        public void showNext(int selection)//second-level menu,get value from previous menu sel1
        {
            while (selection ==1 || selection ==2)//loop if and only if sel1 = 1or2
            {
                if (selection == 1)
                {
                    Console.WriteLine("Species");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("1. Squirrel");
                    Console.WriteLine("2. Howler");
                    Console.WriteLine("3. Colobus");
                }
                else if(selection == 2)
                {
                    Console.WriteLine("Species");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("1. Black");
                    Console.WriteLine("2. Polar");
                }

                Console.WriteLine();
                Console.WriteLine("Selection:");
                sel2 = Convert.ToInt32(Console.ReadLine());

                if (selection == 1)//if monkey selected but sel2 is beyond 1,2 or 3
                {
                    if (sel2 != 1 && sel2 != 2 && sel2 != 3)
                    {
                        Console.WriteLine("Invalid Input");
                        showNext(selection);
                    }
                }
                else
                if(selection == 2)//if bear is selected but sel2 is beyond 1 or 2
                {
                    if (sel2 != 1 && sel2 != 2 )
                    {
                        Console.WriteLine("Invalid Input");
                        showNext(selection);
                    }

                }
                    Console.WriteLine("Weight in KG:");
                    oprand = Convert.ToDouble(Console.ReadLine());
                    if(oprand <= 0) //if input weight is not a positive number
                    {
                        Console.WriteLine("Invalid Input");
                        ShowMain();
                    }
                        selection = 0;//clear selection and jump out of the loop
                
            }
        }


    }
}
