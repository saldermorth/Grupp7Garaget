using GruppUppgiften.Service;
using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace GruppUppgiften.Entity
{
    abstract class CreateVehicle : InputService
    {
        protected Truck CreateTruck()
        {
            Write("Enter in the model: ");
            string model = GetString();
            Write("Enter in brand: ");
            string brand = GetString();
            Write("Enter in color: ");
            string color = GetString();
            Write("Does it have a trailer? True or False: ");
            bool hasTrailer = GetTrueOrFalse();
            Write("What's the max trailer weight?: ");
            int weight = GetInt();
            WriteLine("");

            return new Truck(6, color, "Truck", model, brand, weight, hasTrailer);
        }

        protected Motorcycle CreateMotorcycle()
        {
            Write("Enter in the model: ");
            string model = GetString();
            Write("Enter in brand: ");
            string brand = GetString();
            Write("Enter in color: ");
            string color = GetString();
            Write("Is it an offroad? True or False: ");
            bool offroad = GetTrueOrFalse();
            Write("What's the weight?: ");
            int weight = GetInt();
            WriteLine("");

            return new Motorcycle(2, color, "Motorcycle", model, brand, offroad, weight);
        }

        protected Moped CreateMoped()
        {
            Write("Enter in the model: ");
            string model = GetString();
            Write("Enter in brand: ");
            string brand = GetString();
            Write("Enter in color: ");
            string color = GetString();
            Write("Does it have pedal? True or False: ");
            bool pedal = GetTrueOrFalse();
            Write("Does it have a horn? True or False: ");
            bool hasHorn = GetTrueOrFalse();
            WriteLine("");

            return new Moped(2, color, "Moped", model, brand, pedal, hasHorn);
        }

        protected Bus CreateBus()
        {
            Write("Enter in the model: ");
            string model = GetString();
            Write("Enter in brand: ");
            string brand = GetString();
            Write("Enter in color: ");
            string color = GetString();
            Write("Does it have Toilets? True or False: ");
            bool toilets = GetTrueOrFalse();
            Write("How many levels on the bus?: ");
            int levels = GetInt();
            WriteLine("");

            return new Bus(4, color, "Bus", model, brand, levels, toilets);
        }

        protected Car CreateCar()
        {
            Write("Enter in the model: ");
            string model = GetString();
            Write("Enter in brand: ");
            string brand = GetString();
            Write("Enter in color: ");
            string color = GetString();
            Write("Does it run on petrol? True or False: ");
            bool petrol = GetTrueOrFalse();
            Write("Is it a sport car? True or False: ");
            bool sport = GetTrueOrFalse();
            WriteLine("");

            return new Car(4, color, "Car", model, brand, petrol, sport);
        }
    }
}
