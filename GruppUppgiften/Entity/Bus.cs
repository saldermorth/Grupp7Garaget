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
            return String.Format("|{0,15}|{1,10}|{2,17}|{3,12}|{4,23}|{5,19}| Levels:{6,1}| Toilet:{7,1}", Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, Levels, HasToielts);

           
        }
    }
}