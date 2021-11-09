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
            return String.Format("|{0,8}|{1,16}|{2,10}|{3,18}|{4,11}|{5,23}|{6,19}| Offroad:{7,1}| weight:{8,1}",  Id, Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, IsOffroad, Weight);            
        }
        
    }
}
