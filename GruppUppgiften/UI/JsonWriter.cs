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
    class JsonWriter 
    {
        //private VehicleImpl vehicleImpl = new VehicleImpl();
        const string filePath = @"C:\Users\Nere\source\repos\0-Old projects\Grupp7Garaget\GruppUppgiften\UI\json Files\VehicleList.json";
        public void TextFileSaver(List<Vehicle> vehicles)        
        {                               
           ClientToJsonFile(vehicles);

           JsonToClients();

        }
        public static List<Vehicle> JsonToClients()
        {
            // var vehiclesFromDb = new List<Vehicle>();
            GarageImpl garageImpl = new GarageImpl();
            if (File.Exists(filePath))
            {
                String JSONtxt = File.ReadAllText(filePath);
                var vehiclesFromDb = JsonConvert.DeserializeObject<List<Vehicle>>(JSONtxt);
                if (vehiclesFromDb != null)
                {
                    foreach (Vehicle item in vehiclesFromDb)
                    {
                        Vehicle test = garageImpl.AddVehicle(item);
                        Console.WriteLine(item.Brand);
                    }
                }
                
                return vehiclesFromDb;
            }
            return null;
        }

        public static void ClientToJsonFile(List<Vehicle> vehicles)// List of objects into Jsonfile
        {
            
            var json = JsonConvert.SerializeObject(vehicles);

            string json2 = JsonConvert.SerializeObject(vehicles, Formatting.Indented);

            File.WriteAllText(filePath, json2);
        }
        
    
    }
}
