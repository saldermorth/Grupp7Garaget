using GruppUppgiften.Service;
using GruppUppgiften.UI;
using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using static System.Console;

namespace GruppUppgiften
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bus test = new Bus(3, "blue", "Bus", "People", "Scania", 50, true);
            //GarageImpl garageImpl = new GarageImpl();

            //garageImpl.CreateTypeOfVehicle("CAR");

            //List<Vehicle> temp = garageImpl.ListVehicles();

            //foreach (var item in temp)
            //{
            //    Console.WriteLine(item);
            //}

            Run();
            
            
            //MainMenu run = new MainMenu();
            //run.Meny();

        }
        public static void Run()
        {
            Menu main = new Menu();
            main.MainMenu();
        }
    }
}
