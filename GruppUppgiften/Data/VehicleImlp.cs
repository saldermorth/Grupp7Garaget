using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFolderExemple.Entity;

namespace GruppUppgiften.Data
{
    class VehicleImpl : IVehicle<Vehicle>
    {
        private readonly List<Vehicle> vehicleList = new(); 

        List<Vehicle> IVehicle<Vehicle>.ListVehicles() // Skriv ut lista över alla fordon
        {
            return vehicleList;
        }

        List<Vehicle> IVehicle<Vehicle>.ListTypeOfVehicles(string type) // Listar samtliga olika typer av fordon, samt antal av dessa
        {
            List<Vehicle> temp = new();
            foreach (Vehicle v in vehicleList)
            {
                if(v.Type == type)
                {
                    temp.Add(v);
                }
                return temp;
            }
        }

        IVehicle IVehicle<Vehicle>.AddVehicle(Vehicle obj) // Lägg till ett fordon till listan upp till max kapacitet
        {
            if (!vehicleList.Contains(obj) && obj != null && vehicleList.Count <= 50)
            {
                vehicleList.Add(obj);
            }
            return obj;
        }

        void IVehicle<Vehicle>.RemoveVehicle(int id) // Ta bort specifikt fordon från listan
        {
            for (int i = 0; i < vehicleList.Count; i++)
            {
                if (vehicleList[i].Id.Equals(id))
                {
                    vehicleList.Remove(vehicleList[i]);
                }
            }
        }

        Vehicle IVehicle<Vehicle>.SearchVehicle(int id, string regNum) //Hämta fordon efter id och regnummer
        {
            foreach (Vehicle v in vehicleList)
            {
                if (v.Id.Equals(id) && v.Equals(regNum))
                {
                    return v;
                }
            }
            return null;
        }

        Vehicle IVehicle<Vehicle>.FindType(string type, int id, string regNum) // ** "Möjlighet att söka efter ett flertal fordon på ett flertal valfria variabler." **
        {
            foreach (Vehicle v in vehicleList)
            {
                if (v.GetType().Equals(fordsonstyp))
                {
                    return v;
                }
            }
            return null;
        }
    }
}
