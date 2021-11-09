using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Entity
{
    class Car : Vehicle
    {
        public bool IsPetrol { get; set; }
        public bool IsSportCar { get; set; }
        public Car(int amountofwheeles, string color, string type, string model, string brand, bool isPetrol, bool isSportCar) : base(amountofwheeles, color, type, model, brand)
        {
            IsPetrol = isPetrol;
            IsSportCar = isSportCar;
        }

        public override string ToString()
        {
            return $"Id: {Id}. Type: {Type}. Model: {Model}. Manufacturer: {Brand}. " +
                   $"Color: {Color}. Amount of Wheels: {AmountOfWheeles}. Regnumber: {Reg_Nr}." +
                   $"Is petrol: {IsPetrol}. Is sport car: {IsSportCar}";
        }
    }
}
