using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Data
{
    interface IVehicle
    {
        List<Vehicle> ListVehicles(); // Skriv ut lista över samtliga fordon
        List<Vehicle> ListTypeOfVehicles(string type); // Skriv ut lista över samtliga typer av fordon i garaget och hur många av dessa som står i garaget
        List<Vehicle> ListTheColor(string color); //Lista alla fordon av efterfrågad färg
        List<Vehicle> ListAmountOfWheels(int tyres); //Skriv ut antal däck på fordon
        List<Vehicle> ListModel(string model); // Skrit ut model
        List<Vehicle> ListBrand(string brand);
        Vehicle AddVehicle(Vehicle obj); // Lägg till fordon
        void RemoveVehicle(int id); // Ta bort fordon
        Vehicle SearchVehicle(int id, string regNum); // Sök fordon efter ID (REG-NR)
        Vehicle FindById(int id); // ** "Möjlighet att söka efter ett flertal fordon på ett flertal valfria variabler." Vilka variabler behöver vi? **


    }
}

