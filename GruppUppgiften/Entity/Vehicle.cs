using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften
{
    class Vehicle
    {
        
        private static readonly InputService input = new();
        public int AmountOfWheeles { get; set; }
        public string Color { get; set; }
        public string Reg_Nr { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        
        public Vehicle(int amountofwheeles, string color, string type, string model, string brand)
        {
            AmountOfWheeles = amountofwheeles;
            Color = color;
            Reg_Nr = input.GetRndRegNr();
            Type = type;
            Model = model;
            Brand = brand;
        }
    }
}
