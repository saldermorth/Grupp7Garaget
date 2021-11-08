using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.UI
{
    class SearchMenu
    {                
        public void SearchMeny()
        {   //Counter that starts att one and removes one if up arrow is pressed 
            //and  adds one if down arrow is pressed

            MainMenu Main = new MainMenu();
            string[] menuItems = { "Find By RegNr", "Find All By Color", "Find All By Number Of Wheels", "Find All By Number Of Seats", "Main Menu" };
            int counter = 1;
            bool enterPressed = false;
            ConsoleKeyInfo keyinfo;

            //Menu that shows up when run. Default.
            Console.Clear();
            Main.PrintWithBorders("Search Menu");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Main.PrintWithBorders(menuItems[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Main.PrintWithBorders(menuItems[1]);
            Main.PrintWithBorders(menuItems[2]);
            Main.PrintWithBorders(menuItems[3]);
            Main.PrintWithBorders(menuItems[4]);

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
                        counter = 5;
                    }
                }

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (counter < 5)
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
                    Console.WriteLine("Exit");
                    //activate choice                   
                    switch (counter)
                    {
                        case 1:
                            Console.WriteLine($"Menu {counter} selected");
                            FoundMenu temp = new FoundMenu();
                            temp.SearchMeny();
                            //Find By RegNr
                            break;
                        case 2:
                            Console.WriteLine($"Menu {counter} selected");
                            //Find All By Color
                            break;
                        case 3:
                            Console.WriteLine($"Menu {counter} selected");
                            //Find All By Number Of Wheels
                            break;
                        case 4:
                            Console.WriteLine($"Menu {counter} selected");
                            //Find All By Number Of Seats
                            break;
                        case 5:
                            Console.WriteLine($"Menu {counter} selected");
                            //Main Menu
                            run.Meny();
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
                    Main.PrintWithBorders(menuItems[2]);
                    Main.PrintWithBorders(menuItems[3]);
                    Main.PrintWithBorders(menuItems[4]);
                }
                if (counter == 2)
                {
                    Console.Clear();
                    Main.PrintWithBorders("Search Menu");
                    Main.PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Main.PrintWithBorders(menuItems[2]);
                    Main.PrintWithBorders(menuItems[3]);
                    Main.PrintWithBorders(menuItems[4]);
                }
                if (counter == 3)
                {
                    Console.Clear();
                    Main.PrintWithBorders("Search Menu");
                    Main.PrintWithBorders(menuItems[0]);
                    Main.PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Main.PrintWithBorders(menuItems[3]);
                    Main.PrintWithBorders(menuItems[4]);
                }
                if (counter == 4)
                {
                    Console.Clear();
                    Main.PrintWithBorders("Search Menu");
                    Main.PrintWithBorders(menuItems[0]);
                    Main.PrintWithBorders(menuItems[1]);
                    Main.PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Main.PrintWithBorders(menuItems[4]);
                }
                if (counter == 5)
                {
                    Console.Clear();
                    Main.PrintWithBorders("Search Menu");
                    Main.PrintWithBorders(menuItems[0]);
                    Main.PrintWithBorders(menuItems[1]);
                    Main.PrintWithBorders(menuItems[2]);
                    Main.PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[4]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (counter == 6)
                {
                    enterPressed = true;
                }
            }
        }
    }
}

