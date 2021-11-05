using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Data
{
    interface IVehicle<T>
    {
        List<T> ListVehicles(); // Skriv ut lista över samtliga fordon
        List<T> ListTypeOfVehicles(string type); // Skriv ut lista över samtliga typer av fordon i garaget och hur många av dessa som står i garaget
        T AddVehicle(T obj); // Lägg till fordon
        void RemoveVehicle(int id); // Ta bort fordon
        T SearchVehicle(int id, string regNum); // Sök fordon efter ID (REG-NR)
        T FindType(string type, int id, string regNum); // ** "Möjlighet att söka efter ett flertal fordon på ett flertal valfria variabler." Vilka variabler behöver vi? **


    }
}

