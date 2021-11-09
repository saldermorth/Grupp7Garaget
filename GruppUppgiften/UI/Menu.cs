using GruppUppgiften.Service;
using GruppUppgiften.UI;
using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften
{
    public class Menu
    {
        
        private readonly InputService inputService = new InputService();
        private readonly GarageImpl service = new GarageImpl();
        private List<Vehicle> ListV { get; set; }

        //Mainmenu Knappen skriv ut som title. Fast större kanske. Print with borderMenu title nu metod. 
        public void PrintWithBorders(string k)//Grafisk utskrift. Tar emot ord eller korta meningar. Omringar ordet med en ram och skriver ut. Nollställer foreground färgen i slutet.
        {
            Console.Write($"{ "",40}{"╔"}");
            for (int i = 0; i < 40; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗ \n");

            //Console.WriteLine($"{"║",-26} {"║"}");  // Use incase the box needs to be higher.
            Console.WriteLine($"{"",40}{"║",-10} {k,-30 }{"║"}");
            //Console.WriteLine($"{"║",-26} {"║"}");

            Console.Write($"{"",40}{"╚"}");
            for (int i = 0; i < 40; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝ \n");
            Console.ResetColor();

        }
        public void FoundMenu()
        {
            Menu Main = new Menu();
            //Counter that starts att one and removes one if up arrow is pressed 
            //and adds one if down arrow is pressed

            string[] menuItems = { "Depart vehicle from garage", "Main Menu" };
            int counter = 1;
            bool enterPressed = false;
            ConsoleKeyInfo keyinfo;
            //To do set up DB for testing this menu
            //Menu that shows up when run. Default.
            Console.Clear();

            Main.PrintWithBorders("Found Menu");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Main.PrintWithBorders(menuItems[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Main.PrintWithBorders(menuItems[1]);
            Console.WriteLine();

            Menu run = new Menu();

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
                            // Depart vehicle from garage
                            //RemoveVehicle(Vehicle obj)
                            break;
                        case 2:
                            run.MainMenu();
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
        public void TypeOfVehicleMenu()
        {
            string[] menuItems = { "Bus", "Moped", "Motorcycle", "Truck", "Car", "Main Menu" };
            int counter = 1;
            bool enterPressed = false;
            ConsoleKeyInfo keyinfo;

            //Menu that shows up when run. Default.
            Console.Clear();
            PrintWithBorders("What Type");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            PrintWithBorders(menuItems[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
            PrintWithBorders(menuItems[1]);
            PrintWithBorders(menuItems[2]);
            PrintWithBorders(menuItems[3]);
            PrintWithBorders(menuItems[4]);
            PrintWithBorders(menuItems[5]);

                        

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
                            service.CreateTypeOfVehicle("bus");
                            break;
                        case 2:
                            service.CreateTypeOfVehicle("moped");
                            break;
                        case 3:
                            service.CreateTypeOfVehicle("motorcycle");
                            break;
                        case 4:
                            service.CreateTypeOfVehicle("truck");
                            break;
                        case 5:
                            service.CreateTypeOfVehicle("car");
                            break;
                        case 6:
                            MainMenu();
                            //Main Menu
                            break;

                    }
                    counter = 5;
                }

                if (counter == 1)
                {
                    Console.Clear();
                    PrintWithBorders("What Type");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                    PrintWithBorders(menuItems[5]);

                }
                if (counter == 2)
                {
                    Console.Clear();
                    PrintWithBorders("What Type");
                    PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                    PrintWithBorders(menuItems[5]);
                }
                if (counter == 3)
                {
                    Console.Clear();
                    PrintWithBorders("What Type");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                    PrintWithBorders(menuItems[5]);
                }
                if (counter == 4)
                {
                    Console.Clear();
                    PrintWithBorders("What Type");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[4]);
                    PrintWithBorders(menuItems[5]);
                }
                if (counter == 5)
                {
                    Console.Clear();
                    PrintWithBorders("What Type");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[4]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[5]);
                }
                if (counter == 6)
                {
                    Console.Clear();
                    PrintWithBorders("What Type");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[5]);
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
                if (counter == 7)
                {
                    enterPressed = true;
                }
            }
        }
        public void SearchMenu()
        {
            //Counter that starts att one and removes one if up arrow is pressed 
            //and  adds one if down arrow is pressed
            FoundMenu foundMenu = new FoundMenu();
           
            OutputService outputService = new OutputService();
            Menu Main = new Menu();
            string[] menuItems = { "Find By Id", "Find All By Color", "Find All By Number Of Wheels", "Find All By Number Of Seats", "Main Menu" };
            int counter = 1;
            bool enterPressed = false;
            ConsoleKeyInfo keyinfo;

            //Menu that shows up when run. Default.
            Console.Clear();
            PrintWithBorders("Search Menu");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            PrintWithBorders(menuItems[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
            PrintWithBorders(menuItems[1]);
            PrintWithBorders(menuItems[2]);
            PrintWithBorders(menuItems[3]);
            PrintWithBorders(menuItems[4]);

            Menu run = new Menu();

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
                            Console.WriteLine("Write id number : ");
                            int tempInt = inputService.GetInt();
                            //var vehicle = garageImpl.SearchVehicle();

                            //foundMenu.Menu(vehicle);// send car with
                            //SearchVehicle(Vehicle obj);
                            //Find By RegNr
                            break;
                        case 2:
                            //Find All By Color
                            string color = inputService.GetString();
                            List<Vehicle> vehiclesWhithColor = service.ListTheColor(color);

                            break;
                        case 3:
                            //Find All By Number Of Wheels
                            int amount = inputService.GetInt();
                            service.ListAmountOfWheels(amount);
                            break;
                        case 4:
                            //Find All By Number Of Seats

                            break;
                        case 5:
                            //Main Menu
                            MainMenu();
                            break;
                    }
                    counter = 6;
                }

                if (counter == 1)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                }
                if (counter == 2)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                }
                if (counter == 3)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                }
                if (counter == 4)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[4]);
                }
                if (counter == 5)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[4]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (counter == 6)
                {
                    enterPressed = true;
                }
            }
        }
        public void MainMenu()
        {   //Counter that starts att oone and removes on if up arrow is pressed 
            //and  adds one if down arrow is pressed


            string[] menuItems = { "Search Vehicle", "List All Vehicle", "Park", "Exit" };
            int counter = 1;
            bool enterPressed = false;
            ConsoleKeyInfo keyinfo;

            //Menu that shows up wen run. Default.
            Console.Clear();
            PrintWithBorders("Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            PrintWithBorders(menuItems[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
            PrintWithBorders(menuItems[1]);
            PrintWithBorders(menuItems[2]);
            PrintWithBorders(menuItems[3]);

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
                        counter = 4;
                    }
                }

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (counter < 4)
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
                    //Console.WriteLine("Exit");
                    //activate choice                   
                    switch (counter) // Här aktiveras valet.
                    {
                        case 1:                            
                            SearchMenu();
                            break;
                        case 2:
                            ListV = service.ListVehicles();
                            Console.WriteLine($"|   ID   |      TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES              |");

                            foreach (Vehicle V in ListV)
                            {
                                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------|");
                                Console.WriteLine(V);
                            }

                            
                            Console.ReadKey();
                            break;
                        case 3:                            
                            TypeOfVehicleMenu();
                            //Park                            
                            // garaget.AddVehicle(Vehicle obj);                                
                            break;
                        case 4:
                            //Exit                           
                            //Todo credits
                            Console.ReadKey();
                            break;
                            

                    }
                    counter = 5; // Måste matcha slutvalet.
                }

                if (counter == 1)
                {
                    Console.Clear();
                    PrintWithBorders("Main Menu");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                }
                if (counter == 2)
                {
                    Console.Clear();
                    PrintWithBorders("Main Menu");
                    PrintWithBorders(menuItems[0]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                }
                if (counter == 3)
                {
                    Console.Clear();
                    PrintWithBorders("Main Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[3]);
                }
                if (counter == 4)
                {
                    Console.Clear();
                    PrintWithBorders("Main Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[3]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                if (counter == 5)
                {
                    enterPressed = true;
                    //RollCredits();
                }
            }


        }
        public void PrintInfoOfAllVehicles()
        {
            List<Vehicle> temp = service.ListVehicles();
            //ToDO set and reset screeen size
            int origHeight = Console.WindowHeight;
            int origWidth = Console.WindowWidth;
            // Console.SetWindowSize(150, 55);

            Console.WriteLine($"|   ID   |      TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES              |");

            foreach (Vehicle V in temp)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------|");
                Console.WriteLine(V);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            //run.PrintWithBorders("Return To Main Menu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}

