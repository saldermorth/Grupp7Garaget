using System;

namespace Motorcycle
{
    public class Motorcycle : Vehical
    {
        public bool IsOffroad { get; set; }
        public int Weight { get; set; }
        public Motorcycle(int Id, string type, string Model, string Tillverkare, string Color, int AmountOfWheels, int Reg_Nr, bool IsOffroad, int Weight) : base (amountOfWheels, color, reg_Nr, type, model, tillverkare, id)
        {
            IsOffroad = IsOffroad;
            Weight = Weight;
        }
        public override string ToString()
        {
            return $"Id: {Id}. Type: {type}. Model: {Model}. Tillverkare: {Tillverkare}. " +
                   $"Color: {Color}. Antal hjul: {AmountOfWheeles}. Regnummer: {Reg_Nr}." +
                   $"Is Offroad: {IsOffroad}. Weight: {Weight}";
        }
    }
}