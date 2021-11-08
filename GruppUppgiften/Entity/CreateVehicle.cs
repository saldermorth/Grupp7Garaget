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
            Write("Enter in the type: ");
            string type = GetString();
            Write("Enter in the model: ");
            string model = GetString();
            Write("Enter in brand: ");
            string brand = GetString();
            Write("Enter in color: ");
            string color = GetString();
            Write("Does it have a trailer?: ");
            bool hasTrailer = GetTrueOrFalse();
            Write("What's the max trailer weight?: ");
            int weight = GetInt();
            WriteLine("");

            return new Truck(4, color, type, model, brand, weight, hasTrailer);
        }

        protected Motorcycle CreateMotorcycle()
        {
            Write("Enter in the type: ");
            string type = GetString();
            Write("Enter in the model: ");
            string model = GetString();
            Write("Enter in brand: ");
            string brand = GetString();
            Write("Enter in color: ");
            string color = GetString();
            Write("Is it an offroad?: ");
            bool offroad = GetTrueOrFalse();
            Write("What's the weight?: ");
            int weight = GetInt();
            WriteLine("");

            return new Motorcycle(2, color, type, model, brand, offroad, weight);
        }

        protected Moped CreateMoped()
        {
            Write("Enter in the type: ");
            string type = GetString();
            Write("Enter in the model: ");
            string model = GetString();
            Write("Enter in brand: ");
            string brand = GetString();
            Write("Enter in color: ");
            string color = GetString();
            Write("Does it have pedal? ");
            bool pedal = GetTrueOrFalse();
            Write("Does it have a horn?: ");
            bool hasHorn = GetTrueOrFalse();
            WriteLine("");

            return new Moped(2, color, type, model, brand, pedal, hasHorn);
        }

        protected Bus CreateBus()
        {
            Write("Enter in the type: ");
            string type = GetString();
            Write("Enter in the model: ");
            string model = GetString();
            Write("Enter in brand: ");
            string brand = GetString();
            Write("Enter in color: ");
            string color = GetString();
            Write("Does it have Toilets?: ");
            bool toilets = GetTrueOrFalse();
            Write("How many levels on the bus?: ");
            int levels = GetInt();
            WriteLine("");

            return new Bus(4, color, type, model, brand, levels, toilets);
        }
    }
}
