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
        public Moped(int amountofwheeles, string color, string reg_nr, string type, string model, string tillverkare, int Id, bool ispedal, bool hashorn) : base (amountofwheeles, color, reg_nr, type, model, tillverkare, Id)
        {
            ispedal = IsPedal;
            hashorn = HasHorn;
        }

        public override string ToString()
        {
            return $"Id: {Id}. Type: {Type}. Model: {Model}. Tillverkare: {Tillverkare}. " +
                   $"Color: {Color}. Antal hjul: {AmountOfWheeles}. Regnummer: {Reg_Nr}." +
                   $"Har tuta: {HasHorn}. Ispedal: {IsPedal}"; // Ändra ispedal
        }
    }
}
