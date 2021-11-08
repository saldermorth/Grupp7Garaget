using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppUppgiften.Entity;

namespace GruppUppgiften.Data
{
    class VehicleImpl : IVehicle
    {
        //DB
        private readonly List<Vehicle> vehicleList = new();

        List<Vehicle> IVehicle.ListVehicles()
        {
            return vehicleList;
        }


        List<Vehicle> IVehicle.ListTypeOfVehicles(string type)
        {
            List<Vehicle> temp = new();
            foreach (Vehicle v in vehicleList)
            {
                if (v.Type.Equals(type))
                {
                    temp.Add(v);
                }
            }
            return temp;
        }

        List<Vehicle> IVehicle.ListTheColor(string color)
        {
            List<Vehicle> temp = new();
            foreach (Vehicle v in vehicleList)
            {
                if (v.Color.Equals(color))
                {
                    temp.Add(v);
                }
            }
            return temp;
        }
        List<Vehicle> IVehicle.ListAmountOfWheels(int amount)
        {
            List<Vehicle> temp = new();
            foreach (Vehicle v in vehicleList)
            {
                if (v.AmountOfWheeles == amount)
                {
                    temp.Add(v);
                }
            }
            return temp;
        }

        List<Vehicle> IVehicle.ListModel(string model)
        {
            List<Vehicle> temp = new();
            foreach (Vehicle v in vehicleList)
            {
                if (v.Model.Equals(model))
                {
                    temp.Add(v);
                }
            }
            return temp;
        }
        List<Vehicle> IVehicle.ListBrand(string brand)
        {
            List<Vehicle> temp = new();
            foreach (Vehicle v in vehicleList)
            {
                if (v.Brand.Equals(brand))
                {
                    temp.Add(v);
                }
            }
            return temp;
        }

        Vehicle IVehicle.AddVehicle(Vehicle obj)
        {
            if (!vehicleList.Contains(obj) && obj != null && vehicleList.Count <= 50)
            {
                vehicleList.Add(obj);
            }
            if (vehicleList.Count > 50)
            {
                Console.WriteLine("The garage is full.");
            }
            return obj;
        }

        void IVehicle.RemoveVehicle(int id)
        {
            for (int i = 0; i < vehicleList.Count; i++)
            {
                if (vehicleList[i].Id == id)
                {
                    vehicleList.Remove(vehicleList[i]);
                }
            }
        }

        Vehicle IVehicle.SearchVehicle(int id, string regNum)
        {
            foreach (Vehicle v in vehicleList)
            {
                if (v.Id == id && v.Equals(regNum))
                {
                    return v;
                }
            }
            return null;
        }

        Vehicle IVehicle.FindById(int id)
        {
            foreach (Vehicle v in vehicleList)
            {
                if (v.Id == id)
                {
                    return v;
                }
            }
            return null;
        }
    }
}
