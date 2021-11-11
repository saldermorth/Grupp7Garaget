using GruppUppgiften.Data;
using GruppUppgiften.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppUppgiften.UI
{
    class JsonWriter : GarageImpl
    {
        
        const string filePath = @"C:\Users\berg_\source\repos\Garaget\GruppUppgiften\UI\json Files\VehicleList.json";
       
        public void TextFileSaver(List<Vehicle> vehicles)        
        {                               
           ClientToJsonFile(vehicles);

           //JsonToClients();

        }
        public List<Vehicle> JsonToClients()
        {
             
             List<Vehicle> vehiclesFromDb = null;
             

            String JSONtxt2 = File.ReadAllText(filePath);
           

            List<Vehicle> vehicles22 = new List<Vehicle>();
            
            List<Bus> busFromDb = null;
            busFromDb = JsonConvert.DeserializeObject<List<Bus>>(JSONtxt2);            

            foreach (Vehicle vehicle in busFromDb)
            {
                if (vehicle.Type == "bus")
                {
                    vehicles22.Add((Bus)vehicle);
                    break;
                }               
            }
            var carFromDb = JsonConvert.DeserializeObject<List<Car>>(JSONtxt2);

            foreach (Vehicle vehicle in carFromDb)
            {
                if (vehicle.Type == "car")
                {
                    vehicles22.Add((Car)vehicle);
                    break;
                }
            }

            var mopedFromDb = JsonConvert.DeserializeObject<List<Moped>>(JSONtxt2);

            foreach (Vehicle vehicle in mopedFromDb)
            {
                if (vehicle.Type == "moped")
                {
                    vehicles22.Add((Moped)vehicle);
                    break;
                }
            }

            var motorcycleFromDb = JsonConvert.DeserializeObject<List<Motorcycle>>(JSONtxt2);

            foreach (Vehicle vehicle in motorcycleFromDb)
            {
                if (vehicle.Type == "motorcycle")
                {
                    vehicles22.Add((Motorcycle)vehicle);
                    break;
                }
            }
            var truckFromDb = JsonConvert.DeserializeObject<List<Truck>>(JSONtxt2);

            foreach (Vehicle vehicle in truckFromDb)
            {
                if (vehicle.Type == "truck")
                {
                    vehicles22.Add((Truck)vehicle);
                    break;
                }
            }




            if (File.Exists(filePath))//ToDO file do not exists
            {
                String JSONtxt = File.ReadAllText(filePath);
                // (Bus) JsonConvert.DeserializeObject(JSONtxt, Vehicle.Equals);
                //vehiclesFromDb = JsonConvert.DeserializeObject<List<Vehicle>>(JSONtxt);
                if (vehicles22 != null)
                {
                    foreach (Vehicle item in vehicles22)
                    {
                        
                        AddVehicle(item);                        
                    }
                }                
            }
            return vehicles22;
        }

        public void ClientToJsonFile(List<Vehicle> vehicles)// List of objects into Jsonfile
        {
                           

            var json = JsonConvert.SerializeObject(vehicles);

            string json2 = JsonConvert.SerializeObject(vehicles, Formatting.Indented);

            File.WriteAllText(filePath, json);

        }
        
    
    }
}
