using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.Service
{
    class GarageImpl : IGarage<T>
    {
        //private readonly IVehicel<T> dao = new VehicelImpl();
        public T AddVehicle(T obj)
        {
            //return dao.AddVehicles(obj);
            throw new NotImplementedException();
        }

        public List<T> ListTypeOfVehicles(T obj)
        {
            //List<T> temp = dao.ListTypeOfVehicle(obj.Type);
            //if(!temp.Any())
            //{
            // Console.WriteLine($"There are no Vehicles with type: {obj.Type}");
            //}
            //return temp;
            throw new NotImplementedException();
        }

        public List<T> ListVehicles()
        {
            //List<T> temp = dao.ListVehicle();
            //if(!temp.Any())
            //{
            // Console.WriteLine($"The list is empty.");
            //}
            //return temp;
            throw new NotImplementedException();
        }

        public void RemoveVehicle(int id)
        {
            //T toRemove = dao.FindById(id);
            throw new NotImplementedException();
        }

        public T SearchVehicle(T obj)
        {
            //T toFind = dao.SearchVehicle(obj.Id, obj.Type);
            //if(toFind == null)
            //{
            //    Console.WriteLine($"Could not be found in the list.");
            //}
            //return toFind;
            throw new NotImplementedException();
        }
    }
}
