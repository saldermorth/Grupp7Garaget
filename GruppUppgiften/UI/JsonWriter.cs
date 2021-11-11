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
        //Todo - Michael behöver byta sitt namn mellan users och source
              
        const string filePath = @"C:\Users\berg_\source\repos\Garaget\GruppUppgiften\UI\json Files\VehicleList.json";
       
        public void TextFileSaver(List<Vehicle> vehicles)        
        {                               
           ClientToJsonFile(vehicles);
        }
        public List<Vehicle> JsonToClients(List<Vehicle> vehiclesFromFile)//ListV
        {

            string JSONtxt2 = File.ReadAllText(filePath);// (filePath);

            vehiclesFromFile = new(); // List<Vehicle>();
            
            #region
            var busFromDb = JsonConvert.DeserializeObject<List<Bus>>(JSONtxt2);
           
            foreach (Vehicle vehicle in busFromDb)
            {
                if (vehicle.Type == "bus")
                {
                    vehiclesFromFile.Add((Bus)vehicle);                    
                }               
            }
            var carFromDb = JsonConvert.DeserializeObject<List<Car>>(JSONtxt2);

            foreach (Vehicle vehicle in carFromDb)
            {
                if (vehicle.Type == "car")
                {
                    vehiclesFromFile.Add((Car)vehicle);                    
                }
            }

            var mopedFromDb = JsonConvert.DeserializeObject<List<Moped>>(JSONtxt2);

            foreach (Vehicle vehicle in mopedFromDb)
            {
                if (vehicle.Type == "moped")
                {
                    vehiclesFromFile.Add((Moped)vehicle);                    
                }
            }

            var motorcycleFromDb = JsonConvert.DeserializeObject<List<Motorcycle>>(JSONtxt2);

            foreach (Vehicle vehicle in motorcycleFromDb)
            {
                if (vehicle.Type == "motorcycle")
                {
                    vehiclesFromFile.Add((Motorcycle)vehicle);
                    
                }
            }
            var truckFromDb = JsonConvert.DeserializeObject<List<Truck>>(JSONtxt2);

            foreach (Vehicle vehicle in truckFromDb)
            {
                if (vehicle.Type == "truck")
                {
                    vehiclesFromFile.Add((Truck)vehicle);
                    
                }
            }
            #endregion
            //if (File.Exists(filePath))//ToDO file do not exists
            //{
            //    String JSONtxt = File.ReadAllText(filePath);

            //    if (vehiclesFromFile != null)
            //    {
            //        foreach (Vehicle item in vehiclesFromFile)
            //        {

            //            AddVehicle(item);
            //        }
            //    }
            //}
            return vehiclesFromFile;
        }

        public void ClientToJsonFile(List<Vehicle> vehicles)// List of objects into Jsonfile
        {
                           
            var json = JsonConvert.SerializeObject(vehicles, Formatting.Indented);                       
           //ammend
            File.WriteAllText(filePath, json);
           
        }
        
    
    }
}
