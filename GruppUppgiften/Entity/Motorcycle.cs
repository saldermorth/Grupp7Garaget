using GruppUppgiften;
using System;

namespace GruppUppgiften
{
    class Motorcycle : Vehicle
    {
        public bool IsOffroad { get; set; }
        public int Weight { get; set; }
        public Motorcycle(int amountOfWheeles, string color, string reg_nr, string type, string model, string brand, bool isOffroad, int weight) : base(amountOfWheeles, color, reg_nr, type, model, brand)
        {
            IsOffroad = isOffroad;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"Id: {Id}. Type: {Type}. Model: {Model}. Manufacturer: {Brand}. " +
                   $"Color: {Color}. AmountOfWheeles: {AmountOfWheeles}. License plate: {Reg_Nr}." +
                   $"Is offroad: {IsOffroad}. Weight: {Weight}";
        }
    }
}
