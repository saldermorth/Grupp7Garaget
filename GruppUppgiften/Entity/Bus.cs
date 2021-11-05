using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Entity
{
    class Bus : Vehicle
    {
        public bool HasToielts { get; set; }
        public int Levels { get; set; }
        public Bus(int amountofwheeles, string color, string reg_nr, string type, string model, string tillverkare, int levels, bool hastoielts) : base(amountofwheeles, color, reg_nr, type, model, tillverkare)
        {
            hastoielts = HasToielts;
            levels = Levels;
        }

        public override string ToString()
        {
            return $"Id: {Id}. Type: {Type}. Model: {Model}. Manufacturer: {Tillverkare}. " +
                   $"Color: {Color}. Amount of Wheels: {AmountOfWheeles}. Regnumber: {Reg_Nr}." +
                   $"Levels: {Levels}. Has Toielts: {HasToielts}"; 
        }
    }
}