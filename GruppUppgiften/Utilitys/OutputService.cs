﻿using GruppUppgiften.Service;
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
            Vehicle test = new Vehicle(3,"blue", "asd123", "Truck", "People", "Volvo");
            garaget.AddVehicle(test);

            List<Vehicle> temp = garaget.ListVehicles();

            //(int amountOfWheeles, string color, string reg_nr, string type, string model, string brand, int maxtrailerweight, bool hastrailer)
            foreach (Truck V in temp)
            {
                Console.WriteLine(V); 
            }
            foreach (Truck V in temp)
            {
                Console.WriteLine(V);
            }
            foreach (Truck V in temp)
            {
                Console.WriteLine(V);
            }



        }
    }
}
