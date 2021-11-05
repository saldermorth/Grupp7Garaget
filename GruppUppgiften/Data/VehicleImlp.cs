using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFolderExemple.Entity;   //** Behövs eller kan tas bort? **

namespace GruppUppgiften.Data
{
    class VehicleImpl : IVehicle<Vehicle>
    {
        private readonly List<Vehicle> vehicleList = new(garageCapacity);  // ** Fråga användaren och sätt hur storlek på garaget (garageCapacity?) **

        List<Vehicle> IVehicle<Vehicle>.ListVehicles() // Skriv ut lista över alla fordon
        {
            return vehicleList;
        }

        List<Vehicle> IVehicle<Vehicle>.ListTypeOfVehicles() // Listar samtliga olika typer av fordon, samt antal av dessa
        {
            // ** Skriv ut fordonstyp och antal, men var och hur skriver vi ut fordonstyp/antal? **
            // var count = ListTypeOfVehicles.Count(x => x == model));  Kan denna funka?
            // eller det här från följande sida https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count?view=net-5.0                                               
            // public int Count { get; }
            /* foreach (Part aPart in parts)
            {
            Console.WriteLine(aPart);
            } */
            // Console.WriteLine("\nCapacity: {0}", parts.Capacity);
        }

        IVehicle IVehicle<Vehicle>.AddVehicle(VehicleImpl obj) // Lägg till ett fordon till listan upp till max kapacitet (garageCapacity)
        {
            if (!vehicleList.Contains(obj) && obj != null && vehicleList < garageCapacity)
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

        Vehicle IVehicle<Vehicle>.FindType(string type, int id, string regNum) // ** "Möjlighet att söka efter ett flertal fordon på ett flertal valfria variabler." (Olika fordon, Klassen Vehicle ​och dess ​ärvande subklasser) **
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
