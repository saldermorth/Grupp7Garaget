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

        List<Vehicle> IVehicle.ListVehicles() // Skriv ut lista över alla fordon
        {
            return vehicleList;
        }

        // Listar samtliga olika typer av fordon, samt antal av dessa
        List<Vehicle> IVehicle.ListTypeOfVehicles(string type) //Fordonstyp
        {
            List<Vehicle> temp = new();
            foreach (Vehicle v in vehicleList)
            {
                if(v.Type == type)
                {
                    temp.Add(v);
                }  
            }
            return temp;
        }

        List<Vehicle> IVehicle.ListTheColor(string color) //Fordons färg
        {
            List<Vehicle> temp = new();
            foreach (Vehicle v in vehicleList)
            {
                temp.Add(v);
            }
            return temp;
        }
        List<Vehicle> IVehicle.ListAmountOfWheels(int tyres) //Antal hjul
        {
            List<Vehicle> temp = new();
            foreach (Vehicle v in vehicleList)
            {
                if(v.AmountOfWheeles > 0)
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
                if (v.Model == model)
                {
                    temp.Add(v);
                }
            }
            return temp;
        }
        List<Vehicle> IVehicle.ListBrand(string model)
        {
            List<Vehicle> temp = new();
            foreach (Vehicle v in vehicleList)
            {
                if (v.Tillverkare == model)
                {
                    temp.Add(v);
                }
            }
            return temp;
        }

        Vehicle IVehicle.AddVehicle(Vehicle obj) // Lägg till ett fordon till listan upp till max kapacitet
        {
            if (!vehicleList.Contains(obj) && obj != null && vehicleList.Count <= 50)
            {
                vehicleList.Add(obj);
            }
            return obj;
        }

        void IVehicle.RemoveVehicle(int id) // Ta bort specifikt fordon från listan
        {
            for (int i = 0; i < vehicleList.Count; i++)
            {
                if (vehicleList[i].Id.Equals(id))
                {
                    vehicleList.Remove(vehicleList[i]);
                }
            }
        }

        Vehicle IVehicle.SearchVehicle(int id, string regNum) //Hämta fordon efter id och regnummer
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

        Vehicle IVehicle.FindById(int id) // ** "Möjlighet att söka efter ett flertal fordon på ett flertal valfria variabler." **
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
