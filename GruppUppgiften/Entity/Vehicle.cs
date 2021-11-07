using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften
{
    class Vehicle
    {
        private static int idCounter = 0;
        public int Id { get; set; }
        public int AmountOfWheeles { get; set; }
        public string Color { get; set; }
        public string Reg_Nr { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Tillverkare { get; set; }
        
        public Vehicle(int amountofwheeles, string color, string reg_nr, string type, string model, string tillverkare)
        {
            Id = ++idCounter;
            AmountOfWheeles = amountofwheeles;
            Color = color;
            Reg_Nr = reg_nr;
            Type = type;
            Model = model;
            Tillverkare = tillverkare;
        }
    }
}
