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
        //private VehicleImpl vehicleImpl = new VehicleImpl();
        //C:\Users\berg_\source\repos\Garaget\GruppUppgiften\UI\json Files\VehicleList.json
        const string filePath = @"C:\Users\berg_\source\repos\Garaget\GruppUppgiften\UI\json Files\VehicleList.json";
        //\UI\json Files
        //..\\FolderIcon\\Folder.ico"
        //./Resources/someText.txt)
        public void TextFileSaver(List<Vehicle> vehicles)        
        {                               
           ClientToJsonFile(vehicles);

           JsonToClients();

        }//To do dont save if list is empty
        public List<Vehicle> JsonToClients()
        {
             List<Vehicle> vehiclesFromDb = null;
            
            if (File.Exists(filePath))//ToDO file do not exists
            {
                String JSONtxt = File.ReadAllText(filePath);
                vehiclesFromDb = JsonConvert.DeserializeObject<List<Vehicle>>(JSONtxt);
                if (vehiclesFromDb != null)
                {
                    foreach (Vehicle item in vehiclesFromDb)
                    {                        
                        AddVehicle(item);                        
                    }
                }                
            }
            return vehiclesFromDb;
        }

        public void ClientToJsonFile(List<Vehicle> vehicles)// List of objects into Jsonfile
        {
            
            var json = JsonConvert.SerializeObject(vehicles);

            string json2 = JsonConvert.SerializeObject(vehicles, Formatting.Indented);

            File.WriteAllText(filePath, json2);
        }
        
    
    }
}
