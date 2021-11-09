using GruppUppgiften;
using System;

namespace GruppUppgiften
{
    class Motorcycle : Vehicle
    {
        public bool IsOffroad { get; set; }
        public int Weight { get; set; }
        public Motorcycle(int amountOfWheeles, string color, string type, string model, string brand, bool isOffroad, int weight) : base(amountOfWheeles, color, type, model, brand)
        {
            IsOffroad = isOffroad;
            Weight = weight;
        }
        public override string ToString()
        { 
            return String.Format("|{0,15}|{1,10}|{2,17}|{3,12}|{4,23}|{5,19}| Offroad:{6,1}| weight:{7,1}",  Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, IsOffroad, Weight);            
        }
        
    }
}
