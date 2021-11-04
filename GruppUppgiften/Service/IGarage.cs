using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Service
{
    interface IGarage<T>
    {
        List<T> ListVehicles();
        List<T> ListTypeOfVehicles(T obj);
        T AddVehicle(T obj);
        void RemoveVehicle(int id);
        T FindById(int id);
        T SearchVehicle(T obj);
    }
}
