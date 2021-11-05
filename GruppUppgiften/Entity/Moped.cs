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
        public Moped(int amountofwheeles, string color, string reg_nr, string type, string model, string tillverkare, bool ispedal, bool hashorn) : base (amountofwheeles, color, reg_nr, type, model, tillverkare)
        {
            ispedal = IsPedal;
            hashorn = HasHorn;
        }

        public override string ToString()
        {
            return $"Id: {Id}. Type: {Type}. Model: {Model}. Manufacturer: {Tillverkare}. " +
                   $"Color: {Color}. Amount of Wheels: {AmountOfWheeles}. Regnumber: {Reg_Nr}." +
                   $"Has Horn: {HasHorn}. Is Pedal: {IsPedal}"; // Ändra ispedal
        }
    }
}
