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
                        temp = new Truck(4, color, "Truck", model, brand, weight, hasTrailer);
                        break;
                    }
                case "motorcycle":
                    {
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
                        temp = new Motorcycle(2, color, "Motorcycle", model, brand, offroad, weight);
                        break; 
                    }
                case "moped":
                    {
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
                        temp = new Moped(2, color, "Moped", model, brand, pedal, hasHorn);
                        break;
                    }
                case "car":
                    {
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
                        temp = new Car(4, color, "Car", model, brand, petrol, sport);
                        break;
                    }
                case "bus":
                    {
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
                        temp = new Bus(4, color, "Bus", model, brand, levels, toilets);
                        break;
                    }
                default:
                    Console.WriteLine($"You cant create a {type}.");
                    break;
            }
            return AddVehicle(temp);
        }

        public Vehicle FindById(int id)
        {
            Vehicle toFind = dao.FindById(id);
            if (toFind == null)
            {
                Console.WriteLine($"Could not find vehicle with ID {id}.");
            }
            return toFind;
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

        public void RemoveVehicle(Vehicle obj)
        {
            Vehicle toRemove = FindById(obj.Id);
            dao.RemoveVehicle(toRemove.Id);
        }

        public Vehicle SearchVehicle(Vehicle obj)
        {
            Vehicle toFind = dao.SearchVehicle(obj.Id, obj.Reg_Nr);
            if (toFind == null)
            {
                Console.WriteLine("Could not find the vehicle.");
            }
            return toFind;
        }
    }
}
