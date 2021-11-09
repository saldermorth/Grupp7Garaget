using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Data
{
    interface IVehicle
    {
        List<Vehicle> ListVehicles();
        List<Vehicle> ListTypeOfVehicles(string type);
        List<Vehicle> ListTheColor(string color);
        List<Vehicle> ListAmountOfWheels(int amount);
        List<Vehicle> ListModel(string model);
        List<Vehicle> ListBrand(string brand);
        Vehicle AddVehicle(Vehicle obj);
        void RemoveVehicle(Vehicle obj);
        Vehicle SearchVehicle(string regNum);



    }
}

