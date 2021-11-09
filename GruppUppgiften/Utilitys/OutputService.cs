using GruppUppgiften.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Utilitys
{
    class OutputService
    {

        private readonly GarageImpl garaget = new GarageImpl();
        
        public void PrintInfoOfAllVehicles()
        {                         
           //MainMenu run = new MainMenu();
            //Truck test = new(3,"blue", "Truck", "People", "Ford",50, true);
            //Bus test2 = new(3, "blue", "Bus", "People", "Scania", 50, true);
            //Car test3 = new(3, "blue", "Car", "v70", "Volvo", true, true);
            //Moped test4 = new(3, "blue", "Moped", "Dakota", "Puch", false, true);
            //Motorcycle test5 = new(3, "blue", "Motorcycle", "People", "Volvo", true, 150);
            //garaget.AddVehicle(test5);
            //garaget.AddVehicle(test2);
            //garaget.AddVehicle(test3);
            //garaget.AddVehicle(test4);
            //garaget.AddVehicle(test);
           
            List<Vehicle> temp = garaget.ListVehicles();
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
            //run.MainMeny();
            //Todo set return to main menu
            
            //if (ConsoleKey.Enter)
            //{

            //}
            Console.SetWindowSize(origWidth, origHeight);
            Console.ReadKey();




        }
    }
}
