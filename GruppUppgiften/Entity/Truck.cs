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
            
            return String.Format("|{0,8}|{1,16}|{2,10}|{3,18}|{4,11}|{5,23}|{6,19}| Trailer:{7,1}| Towing Capacity:{8,1}", Id, Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, HasTrailer, MaxTrailerWeight);
            
        }
           
    }
}
