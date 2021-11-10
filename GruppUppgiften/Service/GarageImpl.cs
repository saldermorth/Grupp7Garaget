using GruppUppgiften.Data;
using GruppUppgiften.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GruppUppgiften.Service
{
    class GarageImpl : InputService, IGarage<Vehicle>
    {
        private readonly IVehicle dao = new VehicleImpl();


        public Vehicle AddVehicle(Vehicle obj)
        {
            Vehicle toAdd = dao.AddVehicle(obj);
            if (toAdd == null)
            {
                Console.WriteLine("Could not add vehicle.");
            }
            return toAdd;
        }

        public Vehicle CreateTypeOfVehicle(string type)
        {
            Vehicle temp = null;
            switch (type.ToLower())
            {
                case "truck":
                    {
                        WriteLine("Put in truck details:");
                        Write("Enter in the model: ");
                        string model = GetString();
                        Write("Enter in brand: ");
                        string brand = GetString();
                        Write("Enter in color: ");
                        string color = GetString();
                        Write("Does it have a trailer? Yes or no: ");
                        bool hasTrailer = GetTrueOrFalse();
                        Write("What's the max trailer weight?: ");
                        int weight = GetInt();
                        temp = new Truck(4, color.ToLower(), "truck", model.ToLower(), brand.ToLower(), weight, hasTrailer);
                        break;
                    }
                case "motorcycle":
                    {
                        WriteLine("Put in motorcycle details:");
                        Write("Enter in the model: ");
                        string model = GetString();
                        Write("Enter in brand: ");
                        string brand = GetString();
                        Write("Enter in color: ");
                        string color = GetString();
                        Write("Is it an offroad? Yes or no: ");
                        bool offroad = GetTrueOrFalse();
                        Write("What's the weight?: ");
                        int weight = GetInt();
                        temp = new Motorcycle(2, color.ToLower(), "motorcycle", model.ToLower(), brand.ToLower(), offroad, weight);
                        break; 
                    }
                case "moped":
                    {
                        WriteLine("Put in moped details:");
                        Write("Enter in the model: ");
                        string model = GetString();
                        Write("Enter in brand: ");
                        string brand = GetString();
                        Write("Enter in color: ");
                        string color = GetString();
                        Write("Does it have pedal? Yes or no: ");
                        bool pedal = GetTrueOrFalse();
                        Write("Does it have a horn? Yes or no: ");
                        bool hasHorn = GetTrueOrFalse();
                        temp = new Moped(2, color.ToLower(), "moped", model.ToLower(), brand.ToLower(), pedal, hasHorn);
                        break;
                    }
                case "car":
                    {
                        WriteLine("Put in car details:");
                        Write("Enter in the model: ");
                        string model = GetString();
                        Write("Enter in brand: ");
                        string brand = GetString();
                        Write("Enter in color: ");
                        string color = GetString();
                        Write("Does it run on petrol? Yes or no: ");
                        bool petrol = GetTrueOrFalse();
                        Write("Is it a sport car? Yes or no: ");
                        bool sport = GetTrueOrFalse();
                        temp = new Car(4, color.ToLower(), "car", model.ToLower(), brand.ToLower(), petrol, sport);
                        break;
                    }
                case "bus":
                    {
                        WriteLine("Put in bus details:");
                        Write("Enter in the model: ");
                        string model = GetString();
                        Write("Enter in brand: ");
                        string brand = GetString();
                        Write("Enter in color: ");
                        string color = GetString();
                        Write("Does it have Toilets? Yes or no: ");
                        bool toilets = GetTrueOrFalse();
                        Write("How many levels on the bus?: ");
                        int levels = GetInt();
                        temp = new Bus(4, color.ToLower(), "bus", model.ToLower(), brand.ToLower(), levels, toilets);
                        break;
                    }
                default:
                    Console.WriteLine($"You cant create a {type}.");
                    break;
            }
            return AddVehicle(temp);
        }

        public List<Vehicle> ListAmountOfWheels(int amount)
        {
            List<Vehicle> amountOfWheels = dao.ListAmountOfWheels(amount);
            if (amountOfWheels?.Any() != true)
            {
                Console.WriteLine("The list is empty.");
            }
            return amountOfWheels;
        }

        public List<Vehicle> ListBrand(string brand)
        {
            List<Vehicle> listOfBrand = dao.ListBrand(brand);
            if (listOfBrand?.Any() != true)
            {
                Console.WriteLine("The list is empty.");
            }
            return listOfBrand;
        }

        public List<Vehicle> ListModel(string model)
        {
            List<Vehicle> listOfModel = dao.ListModel(model);
            if (listOfModel?.Any() != true)
            {
                Console.WriteLine("The list is empty.");
            }
            return listOfModel;
        }

        public List<Vehicle> ListTheColor(string color)
        {
            List<Vehicle> listOfColor = dao.ListTheColor(color);
            if (listOfColor?.Any() != true)
            {
                Console.WriteLine("The list is empty.");
            }
            return listOfColor;
        }

        public List<Vehicle> ListTypeOfVehicles(string type)
        {
            List<Vehicle> listOfType = dao.ListTypeOfVehicles(type);
            if (listOfType?.Any() != true)
            {
                Console.WriteLine("The list is empty.");
            }
            return listOfType;
        }

        public List<Vehicle> ListVehicles()
        {
            List<Vehicle> listOfVehicles = dao.ListVehicles();
            if (listOfVehicles?.Any() != true)
            {
                Console.WriteLine("The list is empty.");
            }
            return listOfVehicles;
        }

        public void RemoveVehicle(string regNr)
        {
            Vehicle toRemove = SearchVehicle(regNr);
            dao.RemoveVehicle(toRemove);
        }

        public Vehicle SearchVehicle(string regNr)
        {
            Vehicle toFind = dao.SearchVehicle(regNr);
            if (toFind == null)
            {
                
                Console.WriteLine("\nCould not find the vehicle.\n");
            }
            return toFind;
        }
    }
}
