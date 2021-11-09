using GruppUppgiften;
using System;

namespace GruppUppgiften
{
    class Truck : Vehicle
    {
        public int MaxTrailerWeight { get; set; }
        public bool HasTrailer { get; set; }
        public Truck(int amountOfWheeles, string color, string type, string model, string brand, int maxtrailerweight, bool hastrailer) : base(amountOfWheeles, color, type, model, brand)
        {
            MaxTrailerWeight = maxtrailerweight;
            HasTrailer = hastrailer;
        }
        public override string ToString()
        {
            //
            return String.Format("|{0,15}|{1,10}|{2,17}|{3,12}|{4,23}|{5,19}|Trailer:{6,1}| Towing Capacity:{7,1}", Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, HasTrailer, MaxTrailerWeight);
            
        }
           
    }
}
