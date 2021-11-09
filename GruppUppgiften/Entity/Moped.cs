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
            return String.Format("|{0,8}|{1,16}|{2,10}|{3,18}|{4,11}|{5,23}|{6,19}|Horn:{7,1}|Pedal:{8,1}|", Id, Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, HasHorn, IsPedal);

            //return $"Id: {Id}. Type: {Type}. Model: {Model}. Manufacturer: {Brand}. " +
            //       $"Color: {Color}. Amount of Wheels: {AmountOfWheeles}. Licens plate: {Reg_Nr}." +
            //       $"Has Horn: {HasHorn}. Is Pedal: {IsPedal}";
        }
    }
}
