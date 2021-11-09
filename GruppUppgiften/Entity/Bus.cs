using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften
{
    class Bus : Vehicle
    {
        public bool HasToielts { get; set; }
        public int Levels { get; set; }
        public Bus(int amountofwheeles, string color, string type, string model, string brand, int levels, bool hasToielts) : base(amountofwheeles, color, type, model, brand)
        {
            HasToielts = hasToielts;
            Levels = levels;
        }

        public override string ToString()
        {
            return $"Id: {Id}. Type: {Type}. Model: {Model}. Manufacturer: {Brand}. " +
                   $"Color: {Color}. Amount of Wheels: {AmountOfWheeles}. Regnumber: {Reg_Nr}." +
                   $"Levels: {Levels}. Has Toielts: {HasToielts}";
        }
    }
}