using GruppUppgiften;
using System;

namespace Truck
{
    class Truck : Vehicle
    {
        public int MaxTrailerWeight { get; set; }
        public bool HasTrailer { get; set; }
        public Truck(int amountOfWheeles, string color, string reg_nr, string type, string model, string brand, int maxtrailerweight, bool hastrailer) : base(amountOfWheeles, color, reg_nr, type, model, brand)
        {
            MaxTrailerWeight = maxtrailerweight;
            HasTrailer = hastrailer;
        }
        public override string ToString()
        {
            return $"Id: {Id}. Type: {Type}. Model: {Model}. Manufacturer: {Brand}. " +
                   $"Color: {Color}. AmountOfWheeles: {AmountOfWheeles}. License plate: {Reg_Nr}." +
                   $"HasTrailer: {HasTrailer}. MaxTrailerWeight: {MaxTrailerWeight}";
        }
    }
}
