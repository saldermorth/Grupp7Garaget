using GruppUppgiften;
using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.UI
{
    class TypeOfVehicleMenu
    {
        public void Menu()
        {
            MainMenu Main = new MainMenu();
            string[] menuItems = { "Buss", "Moped", "Motorcycle", "Truck", "Car" , "Main Menu" };
            int counter = 1;
            bool enterPressed = false;
            ConsoleKeyInfo keyinfo;

            //Menu that shows up when run. Default.
            Console.Clear();
            Main.PrintWithBorders("What Type");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Main.PrintWithBorders(menuItems[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Main.PrintWithBorders(menuItems[1]);
            Main.PrintWithBorders(menuItems[2]);
            Main.PrintWithBorders(menuItems[3]);
            Main.PrintWithBorders(menuItems[4]);
            Main.PrintWithBorders(menuItems[5]);


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
                        counter = 6;
                    }
                }
               

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (counter < 6)
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
                            FoundMenu temp = new FoundMenu();
                            //SearchVehicle(Vehicle obj);
                            //Find By RegNr
                            break;
                        case 2:
                            //Find All By Color
                            //ListTheColor(string color);
                            break;
                        case 3:
                            //Find All By Number Of Wheels
                            //ListAmountOfWheels(int amount);
                            break;
                        case 4:
                            //Find All By Number Of Seats
                            //RemoveVehicle(Vehicle obj);
                            break;
                        case 5:

                            //Car
                            break;
                        case 6:
                            //Main menu
                            run.Meny();
                            //Main Menu
                            break;

                    }
                    counter = 5;
                }

                if (counter == 1)
                {
                    Console.Clear();
                    Main.PrintWithBorders("What Type");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Main.PrintWithBorders(menuItems[1]);
                    Main.PrintWithBorders(menuItems[2]);
                    Main.PrintWithBorders(menuItems[3]);
                    Main.PrintWithBorders(menuItems[4]);
                    Main.PrintWithBorders(menuItems[5]);

                }
                if (counter == 2)
                {
                    Console.Clear();
                    Main.PrintWithBorders("What Type");
                    Main.PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Main.PrintWithBorders(menuItems[2]);
                    Main.PrintWithBorders(menuItems[3]);
                    Main.PrintWithBorders(menuItems[4]);
                    Main.PrintWithBorders(menuItems[5]);
                }
                if (counter == 3)
                {
                    Console.Clear();
                    Main.PrintWithBorders("What Type");
                    Main.PrintWithBorders(menuItems[0]);
                    Main.PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Main.PrintWithBorders(menuItems[3]);
                    Main.PrintWithBorders(menuItems[4]);
                    Main.PrintWithBorders(menuItems[5]);
                }
                if (counter == 4)
                {
                    Console.Clear();
                    Main.PrintWithBorders("What Type");
                    Main.PrintWithBorders(menuItems[0]);
                    Main.PrintWithBorders(menuItems[1]);
                    Main.PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Main.PrintWithBorders(menuItems[4]);
                    Main.PrintWithBorders(menuItems[5]);
                }
                if (counter == 5)
                {
                    Console.Clear();
                    Main.PrintWithBorders("What Type");
                    Main.PrintWithBorders(menuItems[0]);
                    Main.PrintWithBorders(menuItems[1]);
                    Main.PrintWithBorders(menuItems[2]);
                    Main.PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[4]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Main.PrintWithBorders(menuItems[5]);
                }
                if (counter == 6)
                {
                    Console.Clear();
                    Main.PrintWithBorders("What Type");
                    Main.PrintWithBorders(menuItems[0]);
                    Main.PrintWithBorders(menuItems[1]);
                    Main.PrintWithBorders(menuItems[2]);
                    Main.PrintWithBorders(menuItems[3]);
                    Main.PrintWithBorders(menuItems[4]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Main.PrintWithBorders(menuItems[5]);
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
                if (counter == 7)
                {
                    enterPressed = true;
                }

            }

        }
    }
}
