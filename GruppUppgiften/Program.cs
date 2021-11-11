using GruppUppgiften.Service;
using GruppUppgiften;
using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using static System.Console;
using GruppUppgiften.UI;
using GruppUppgiften.Data;

namespace GruppUppgiften
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetBufferSize(155,40);
            Console.SetWindowSize(155, 40);

            Run();
            
            

        }
        public static void Run()
        {
            //GarageImpl service = new GarageImpl();
            //service.AddVehicleListFromDB(JsonWriter.JsonToClients());
            //garageImpl.AddVehicleListFromDB(JsonWriter.JsonToClients());
            Menu main = new Menu();
            main.MainMenu();
            



        }
    }
}
