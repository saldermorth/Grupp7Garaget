using System;

namespace Motorcycle
{
    public class Motorcycle : Vehical
    {
        public bool IsOffroad { get; set; }
        public int Weight { get; set; }
        public Motorcycle(int Id, string type, string Model, string ,string Manufacturer, string Color, int AmountOfWheeles, int LicensePlate, bool IsOffroad, int Weight) : base (amountOfWheels, color, reg_Nr, type, model, tillverkare, id)
        {
            IsOffroad = IsOffroad;
            Weight = Weight;
        }
        public override string ToString()
        {
            return $"Id: {Id}. Type: {type}. Model: {Model}. Manufacturer: {Manufacturer}. " +
                   $"Color: {Color}. AmountOfWheeles: {AmountOfWheeles}. License plate: {LicensePlate}." +
                   $"Is Offroad: {IsOffroad}. Weight: {Weight}";
        }
    }
}
