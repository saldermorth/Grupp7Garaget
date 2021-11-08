﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Service
{
    interface IGarage<Vehicle>
    {
        List<Vehicle> ListVehicles();
        List<Vehicle> ListTypeOfVehicles(string type);
        List<Vehicle> ListTheColor(string color);
        List<Vehicle> ListAmountOfWheels(int amount);
        List<Vehicle> ListModel(string model);
        List<Vehicle> ListBrand(string brand);
        Vehicle AddVehicle(Vehicle obj);
        void RemoveVehicle(Vehicle obj);
        Vehicle FindById(int id);
        Vehicle SearchVehicle(Vehicle obj);
        Vehicle CreateTypeOfVehicle(string type);
    }
}
