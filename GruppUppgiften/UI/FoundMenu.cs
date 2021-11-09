using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.UI
{
    class FoundMenu
    {
        
        public void SearchMeny()
        {
            MainMenu Main = new MainMenu();
            //Counter that starts att one and removes one if up arrow is pressed 
            //and adds one if down arrow is pressed

            string[] menuItems = { "Depart vehicle from garage", "Main Menu" };
            int counter = 1;
            bool enterPressed = false;
            ConsoleKeyInfo keyinfo;

            //Menu that shows up when run. Default.
            Console.Clear();
            Main.PrintWithBorders("Found Menu");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Main.PrintWithBorders(menuItems[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Main.PrintWithBorders(menuItems[1]);
       
            MainMenu run = new MainMenu();

            while (enterPressed == false)
            {
                keyinfo = Console.ReadKey();

                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (counter > 1)
                    {
                        counter--;
                    }
                    else
                    {
                        counter = 2;
                    }
                }

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (counter < 2)
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                }


                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    
                    //activate choice                   
                    switch (counter)
                    {
                        case 1:
                            //Depart vehicle from garage
                            // RemoveVehicle(Vehicle obj)
                            break;
                        case 2:                          
                             run.Meny();
                            //Main Menu
                            break;
                    }
                    counter = 6;
                }

                if (counter == 1)
                {
                    Console.Clear();
                    Main.PrintWithBorders("Search Menu");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Main.PrintWithBorders(menuItems[1]);
                 
                }
                if (counter == 2)
                {
                    Console.Clear();
                    Main.PrintWithBorders("Search Menu");
                    Main.PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                  
                }                       
                if (counter == 3)
                {
                    enterPressed = true;
                }
            }
        }
    }
}
