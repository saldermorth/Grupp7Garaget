using GruppUppgiften.Entity;
using GruppUppgiften.Service;
using System;
using System.Collections.Generic;
using static System.Console;

namespace GruppUppgiften
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Testar git");
            GarageImpl service = new();
            Bus a = new(4, "blue", "abc123", "bus", "busX2012", "Honda", 2, true);
            service.AddVehicle(a);
            List<Vehicle> toPrint = service.ListVehicles();
            foreach (var item in toPrint)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
