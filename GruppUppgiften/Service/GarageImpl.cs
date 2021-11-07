using GruppUppgiften.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Service
{
    class GarageImpl : IGarage<Vehicle>
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
