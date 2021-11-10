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

        //public override bool Equals(object obj)
        //{
        //    return obj is Vehicle vehicle &&
        //           AmountOfWheeles == vehicle.AmountOfWheeles &&
        //           Color == vehicle.Color &&
        //           Reg_Nr == vehicle.Reg_Nr &&
        //           Type == vehicle.Type &&
        //           Model == vehicle.Model &&
        //           Brand == vehicle.Brand;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(AmountOfWheeles, Color, Reg_Nr, Type, Model, Brand);
        //}
    }
}
