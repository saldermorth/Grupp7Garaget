using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften
{
    class Moped : Vehicle
    {
        public bool IsPedal { get; set; }
        public bool HasHorn { get; set; }
        public Moped(int amountofwheeles, string color, string type, string model, string brand, bool isPedal, bool hasHorn) : base(amountofwheeles, color, type, model, brand)
        {
            IsPedal = isPedal;
            HasHorn = hasHorn;
        }

        public override string ToString()
        {
            return String.Format("|{0,15}|{1,10}|{2,17}|{3,12}|{4,23}|{5,19}| Horn:{6,1}| Pedal:{7,5}", Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, HasHorn, IsPedal);
                        
        }
    }
}
