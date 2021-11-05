﻿using System;

namespace Motorcycle
{
    public class Truck : Vehical
    {
        public int MaxTrailerWeight { get; set; }
        public bool HasTrailer { get; set; }
        public Truck(int id, string type, string model, string tillverkare, string color, int amountOfWheeles, int reg_nr, int maxtrailerweight,bool hastrailer,int weight) : base(amountOfWheels, color, reg_Nr, type, model, tillverkare, id)
        {
            maxtrailerweight = MaxTrailerWeight;
            hastrailer = HasTrailer;
        }
        public override string ToString()
        {
            return $"Id: {Id}. Type: {type}. Model: {Model}. Manufacturer: {Tillverkare}. " +
                   $"Color: {Color}. AmountOfWheeles: {AmountOfWheeles}. License plate: {Reg_Nr}." +
                   $"HasTrailer: {HasTrailer}. MaxTrailerWeight: {MaxTrailerWeight} Weight: {Weight}";
        }
    }
}