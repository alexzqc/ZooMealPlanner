using System;

namespace ZooMealPlanner
{
    class Program
    {
        static void Main(string[] args)
        {   
            //get menu from Menu
            Menu menu = new Menu();

            //create new objects
            Mammal[] monkeyArray = new Monkey[3];
            monkeyArray[0] = new Monkey(0.006, "Squirrel");
            monkeyArray[1] = new Monkey(0.007, "Howler");
            monkeyArray[2] = new Monkey(0.008, "Colobus");
            Mammal[] bearArray = new Bears[2];
            bearArray[0] = new Bears("berries, green vegetation, flowers, fruits, fish", 0.014, "Black");
            bearArray[1] = new Bears("berries, fish", 0.016, "Polar");


            //start of the loop
            while (true) { 
            menu.ShowMain();
                if (menu.sel1 == 3)
                {
                    break;
                }

            menu.showNext(menu.sel1);
                int i = menu.sel2 - 1;

                //selection of if it is monkey or bear
                if (menu.sel1 ==1) { 
                    Mammal monkeySel = monkeyArray[i];
                    monkeySel.printdetails(menu.oprand);
                } else if (menu.sel1 == 2)
                {
                    Mammal bearSel = bearArray[i];
                    bearSel.printdetails(menu.oprand);
                }
                 
                menu.sel1 = 0;//clear sel1 for a new loop

            }
        }
    }
}
