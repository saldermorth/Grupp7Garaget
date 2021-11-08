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
            return $"Id: {Id}. Type: {Type}. Model: {Model}. Manufacturer: {Brand}. " +
                   $"Color: {Color}. Amount of Wheels: {AmountOfWheeles}. Licens plate: {Reg_Nr}." +
                   $"Has Horn: {HasHorn}. Is Pedal: {IsPedal}";
        }
    }
}
