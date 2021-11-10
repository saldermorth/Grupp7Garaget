using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppUppgiften;

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

        void IVehicle.RemoveVehicle(Vehicle obj)
        {
            for (int i = 0; i < vehicleList.Count; i++)
            {
                if (vehicleList[i].Equals(obj))
                {
                    Vehicle temp = vehicleList[i];
                    vehicleList.Remove(temp);
                }
            }
        }

        Vehicle IVehicle.SearchVehicle(string regNum)
        {
            foreach (Vehicle v in vehicleList)
            {
                if (v.Reg_Nr.Equals(regNum))
                {
                    return v;
                }
            }
            return null;
        }
    }
}
