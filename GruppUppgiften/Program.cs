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
