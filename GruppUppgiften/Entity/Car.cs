using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften
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
            return String.Format("|{0,8}|{1,16}|{2,10}|{3,18}|{4,11}|{5,23}|{6,19}|Gas:{7,1}|Sporty:{8,1}|", Id, Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, IsPetrol, IsSportCar);
            //return $"Id: {Id}. Type: {Type}. Model: {Model}. Manufacturer: {Brand}. " +
            //       $"Color: {Color}. Amount of Wheels: {AmountOfWheeles}. Regnumber: {Reg_Nr}." +
            //       $"Is petrol: {IsPetrol}. Is sport car: {IsSportCar}";
        }
    }
}
