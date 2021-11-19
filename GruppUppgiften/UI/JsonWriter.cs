using GruppUppgiften.Data;
using GruppUppgiften.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GruppUppgiften.UI
{
    class JsonWriter : GarageImpl
    {
        //Todo - För att testa IO-delen så behöver man leta upp på sin dator, vägen där "VehicleList.json" filen ligger och kopiera in den som nedan.



        const string filePath = @"C:\Users\Anton\source\repos\Grupp7Garaget\GruppUppgiften\UI\json Files\VehicleList.json";

        public static void TextFileSaver(List<Vehicle> vehicles)
        {
            
           
            ClientToJsonFile(vehicles);
        }
        public static List<Vehicle> JsonToClients()//ListV
        {

            string CreatPath = AppDomain.CurrentDomain.BaseDirectory + @"GustavsNyaFil.json";
            string JSONtxt2 = File.ReadAllText(CreatPath);// (filePath);

            List<Vehicle> vehiclesFromFile = new(); // List<Vehicle>();
            if (JSONtxt2 == null || JSONtxt2 == "")
            {
                return null;
            }
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

            return vehiclesFromFile;
        }

        public static void ClientToJsonFile(List<Vehicle> vehicles)// List of objects into Jsonfile
        {
            string CreatPath = AppDomain.CurrentDomain.BaseDirectory + @"GustavsNyaFil.json";
            var json = JsonConvert.SerializeObject(vehicles, Formatting.Indented);
            //ammend
            File.WriteAllText(CreatPath, json);

        }


    }
}
