using GruppUppgiften.Service;
using GruppUppgiften;
using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppUppgiften.UI;
using GruppUppgiften.Data;

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

            string[] menuItems = { "Find By Brand", "Find By Model", "Find All By Color", "Find All By Number Of Wheels", "Find By Type", "Find A Vehicle", "Main Menu" };
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
            PrintWithBorders(menuItems[5]);
            PrintWithBorders(menuItems[6]);

            Menu run = new Menu(); // TODO ????

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
                        counter = 7;
                    }
                }

                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (counter < 7)
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
                            PrintVehicleByBrand();
                            //Find By Brand
                            break;
                        case 2:
                            PrintVehicleByModel();
                            //Find All By Model                            

                            break;
                        case 3:
                            PrintVehicleByColor();
                            //Find All By color                            
                            break;
                        case 4:

                            //Find by wheeles
                            PrintVehicleByNumWheeles();
                            break;
                        case 5:
                            PrintVehicleByType();
                            //Find by type
                            break;
                        case 6:
                            PrintAVehicle();
                            //Find a Vehicle
                            break;
                        case 7:
                            //Main Menu
                            MainMenu();
                            break;
                    }
                    counter = 7;
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
                    PrintWithBorders(menuItems[5]);
                    PrintWithBorders(menuItems[6]);

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
                    PrintWithBorders(menuItems[5]);
                    PrintWithBorders(menuItems[6]);
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
                    PrintWithBorders(menuItems[5]);
                    PrintWithBorders(menuItems[6]);
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
                    PrintWithBorders(menuItems[5]);
                    PrintWithBorders(menuItems[6]);
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
                    PrintWithBorders(menuItems[5]);
                    PrintWithBorders(menuItems[6]);
                }
                if (counter == 6)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[5]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    PrintWithBorders(menuItems[6]);
                }
                if (counter == 7)
                {
                    Console.Clear();
                    PrintWithBorders("Search Menu");
                    PrintWithBorders(menuItems[0]);
                    PrintWithBorders(menuItems[1]);
                    PrintWithBorders(menuItems[2]);
                    PrintWithBorders(menuItems[3]);
                    PrintWithBorders(menuItems[4]);
                    PrintWithBorders(menuItems[5]);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    PrintWithBorders(menuItems[6]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (counter == 8)
                {
                    enterPressed = true;
                }
            }
        }
        public void MainMenu()
        {
            
            

            //Counter that starts att oone and removes on if up arrow is pressed 
            //and  adds one if down arrow is pressed
            ;//Todo - db not filling
            string[] menuItems = { "Search Vehicle", "List All Vehicle", "Park", "Load From File", "Exit And Save" };
            int counter = 1;
            bool enterPressed = false;
            ConsoleKeyInfo keyinfo;

            //Menu that shows up when run. Default.
            Console.Clear();
            PrintWithBorders("Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            PrintWithBorders(menuItems[0]);
            Console.ForegroundColor = ConsoleColor.Gray;
            PrintWithBorders(menuItems[1]);
            PrintWithBorders(menuItems[2]);
            PrintWithBorders(menuItems[3]);
            PrintWithBorders(menuItems[4]);

            while (enterPressed == false && counter  < 7 )
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
                    //Console.WriteLine("Exit");
                    //activate choice                   
                    switch (counter) // Här aktiveras valet.
                    {
                        case 1:
                            SearchMenu();
                            break;
                        case 2:
                            PrintInfoOfAllVehicles();
                            break;
                        case 3:
                            TypeOfVehicleMenu();
                            //Park                            
                            // garaget.AddVehicle(Vehicle obj);                                
                            break;
                        case 4:
                            service.AddVehicleListFromDB(JsonWriter.JsonToClients());
                            //Console.WriteLine("To Remove your car");
                            //Console.Write("Input Reg Number : ");
                            //string regNum = inputService.GetString();                            
                            //Vehicle temp = service.SearchVehicle(regNum);
                            //Console.WriteLine(temp);
                            //service.RemoveVehicle(regNum);
                            //Console.WriteLine("Vehicle has been removed");
                            //Console.ReadKey();
                            MainMenu();
                            break;
                        case 5:
                            JsonWriter jsonWriter = new JsonWriter();
                            jsonWriter.TextFileSaver(ListV); //Save to menu
                            Credits credits = new Credits();
                            credits.CreditsLoop();
                            break;
                    }
                    counter = 6; // Måste matcha slutvalet.
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
                    PrintWithBorders(menuItems[4]);
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
                    PrintWithBorders(menuItems[4]);
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
                    PrintWithBorders(menuItems[4]);
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
                    PrintWithBorders(menuItems[4]);
                }
                if (counter == 5)
                {
                    Console.Clear();
                    PrintWithBorders("Main Menu");
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
                    //RollCredits();
                }
            }


        }// Här dör appen

        //"Find By BrandXXX", "Find By ModelXXX", "Find All By ColorXXX", "Find All By Number Of Wheels", "Find By TypeXXX", "Main Menu" 
        public void PrintAVehicle()
        {
            Console.WriteLine("To Find Your Car");
            Console.Write("Enter RegNumber : ");

            string input = inputService.GetString();
            Vehicle temp = service.SearchVehicle(input);

            Console.WriteLine($"|     TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES              |");

            Console.WriteLine(temp);

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------|");

            Console.ForegroundColor = ConsoleColor.Blue;
            PrintWithBorders("Return To Main Menu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
           

        }
        public void PrintVehicleByNumWheeles()
        {
            Console.WriteLine("Enter Number of wheeles");
            int input = Convert.ToInt32(inputService.GetInt());

            ListV = service.ListAmountOfWheels(input);

            Console.WriteLine($"|     TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES              |");

            foreach (Vehicle v in ListV)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------|");
                Console.WriteLine(v);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            PrintWithBorders("Return To Main Menu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
        public void PrintVehicleByColor()
        {
            Console.WriteLine("Enter Color");
            string input = inputService.GetString();

            ListV = service.ListTheColor(input.ToLower());

            Console.WriteLine($"|     TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES              |");

            foreach (Vehicle v in ListV)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------|");
                Console.WriteLine(v);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            PrintWithBorders("Return To Main Menu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
        public void PrintVehicleByModel()
        {
            Console.WriteLine("Enter Model");
            string input = inputService.GetString();

            ListV = service.ListModel(input.ToLower());

            Console.WriteLine($"|     TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES              |");

            foreach (Vehicle v in ListV)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------|");
                Console.WriteLine(v);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            PrintWithBorders("Return To Main Menu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
        public void PrintVehicleByBrand()
        {
            Console.WriteLine("Enter Brand"); ;
            string input = inputService.GetString();

            ListV = service.ListBrand(input.ToLower());

            Console.WriteLine($"|     TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES              |");

            foreach (Vehicle v in ListV)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------|");
                Console.WriteLine(v);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            PrintWithBorders("Return To Main Menu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();

        }
        public void PrintVehicleByType()
        {
            Console.WriteLine("Enter type");
            Console.WriteLine("Bus, Truck, Car, Motorcycle or Moped");
            string input = inputService.GetString();

            ListV = service.ListTypeOfVehicles(input.ToLower());

            Console.WriteLine($"|     TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES              |");

            foreach (Vehicle v in ListV)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------|");
                Console.WriteLine(v);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            PrintWithBorders("Return To Main Menu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
        public void PrintInfoOfAllVehicles()
        {
            ListV = service.ListVehicles();

            Console.WriteLine($"|     TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES              |");

            foreach (Vehicle v in ListV)
            {
                if (v.ToString() == "GruppUppgiften.Vehicle")
                {
                    string str =String.Format("|{0,15}|{1,10}|{2,17}|{3,12}|{4,23}|{5,19}|", v.Type, v.Model, v.Brand, v.Color, v.AmountOfWheeles, v.Reg_Nr);
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine(v.ToString());
                }
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------|");
                
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            PrintWithBorders("Return To Main Menu");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            MainMenu();
        }
    }
}

