using GruppUppgiften;
using GruppUppgiften.Service;
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
        /*
        public void Menu()
        {
            GarageImpl garageImpl = new GarageImpl();
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
                            garageImpl.CreateTypeOfVehicle("bus");                           
                            break;
                        case 2:
                            garageImpl.CreateTypeOfVehicle("moped");
                            break;
                        case 3:
                            garageImpl.CreateTypeOfVehicle("motorcycle");
                            break;
                        case 4:
                            garageImpl.CreateTypeOfVehicle("truck");
                            break;
                        case 5:
                            garageImpl.CreateTypeOfVehicle("car");                            
                            break;
                        case 6:                            
                            run.MainMeny();
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
      */
    }
}
