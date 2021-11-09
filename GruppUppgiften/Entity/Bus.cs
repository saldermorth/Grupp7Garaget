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
            return String.Format("|{0,8}|{1,16}|{2,10}|{3,18}|{4,11}|{5,23}|{6,19}| Levels:{7,1}| Toilet:{8,1}", Id, Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, Levels, HasToielts);

           
        }
    }
}