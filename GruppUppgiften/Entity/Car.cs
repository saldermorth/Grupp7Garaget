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
            return String.Format("|{0,15}|{1,10}|{2,17}|{3,12}|{4,23}|{5,19}| Gas:{6,1}| Sporty:{7,1}", Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, IsPetrol, IsSportCar);
            
        }
    }
}
