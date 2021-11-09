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
        { //($"|   ID   |      TYPE      |   MODEL  |   MANUFACTURER   |   COLOR   |   NUMBER OF WHEELES   |   LICENS NUMBER   |   SPECIAL FEUTURES");
            return String.Format("|{0,8}|{1,16}|{2,10}|{3,18}|{4,11}|{5,23}|{6,19}|Offroad:{7,1}|weight:{8,1}|",  Id, Type, Model, Brand, Color, AmountOfWheeles, Reg_Nr, IsOffroad, Weight);
            //return $"|   {Id}    |   {Type}   |    {Model}     {Brand}  |  {Color}  | {AmountOfWheeles}  |  {Reg_Nr}  | Is offroad: {IsOffroad}. Weight: {Weight}";
        }
        //return $"Id: {Id}. Type: {Type}. Model: {Model}. Manufacturer: {Brand}. Color: {Color}. AmountOfWheeles: {AmountOfWheeles}. License plate: {Reg_Nr}." +
        //           $"Is offroad: {IsOffroad}. Weight: {Weight}";
    }
}
