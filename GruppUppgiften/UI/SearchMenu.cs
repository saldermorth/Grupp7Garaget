using GruppUppgiften.Service;
using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.UI
{
    class SearchMenu
    {            
        
        public void Meny()
        {   //Counter that starts att one and removes one if up arrow is pressed 
            //and  adds one if down arrow is pressed
            FoundMenu foundMenu = new FoundMenu();
            GarageImpl garageImpl = new GarageImpl();
            InputService inputService = new InputService();
            OutputService outputService = new OutputService();
            MainMenu Main = new MainMenu();
            string[] menuItems = { "Find By Id", "Find All By Color", "Find All By Number Of Wheels", "Find All By Number Of Seats", "Main Menu" };
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
                    //activate choice                   
                    switch (counter)
                    {
                        case 1:
                            int tempInt = inputService.GetInt();
                            var vehicle = garageImpl.FindById(tempInt);                            
                          
                            foundMenu.Meny(vehicle);// send car with
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
                            
                            break;
                        case 5:                            
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

