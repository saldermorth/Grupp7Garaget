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
            Truck test = new(3,"blue", "Truck", "People", "Ford",50, true);
            Bus test2 = new(3, "blue", "Bus", "People", "Scania", 50, true);
            Car test3 = new(3, "blue", "Car", "v70", "Volvo", true, true);
            Moped test4 = new(3, "blue", "Moped", "Dakota", "Puch", false, true);
            Motorcycle test5 = new(3, "blue", "Motorcycle", "People", "Volvo", true, 150);
            garaget.AddVehicle(test5);
            garaget.AddVehicle(test2);
            garaget.AddVehicle(test3);
            garaget.AddVehicle(test4);
            garaget.AddVehicle(test);

            List<Vehicle> temp = garaget.ListVehicles();
            //ToDO set and reset screeen size
            //(int amountOfWheeles, string color, string reg_nr, string type, string model, string brand, int maxtrailerweight, bool hastrailer)
            //string[] C = { "ID", "TYPE", "MODEL", "MANUFACTURER", "COLOR", "NUMBER OF WHEELES", "LICENS NUMBER", "SPECIAL FEUTURES" };
            //Console.WriteLine(
            //String.Format("|{0,5}{1,5}{2,15}{3,15}{4,15}{5,15}{6,15}{7,15}{8,15}{9,15}{10,15}{11,15}{12,15}{13,15}{14,15}{15,15}", C[0],"|", C[1], "|", C[2], "|", C[3], "|", C[4], "|", C[5], "|", C[6], "|", C[7],"|"));
            Console.WriteLine($"|   ID   |      TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES   |");
         
            foreach (Vehicle V in temp)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(V); 
            }
            Console.ReadLine();
            



        }
    }
}
