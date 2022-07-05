
using System;
using System.Collections.Generic;
using System.Linq;
 
namespace VehicleCatalgoue
{
    class VehicleCatalgoue
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var vehicleList = new List<Vehicle>();
            while (input != "End")
            {
                var inputSplit = input.Split().ToArray();

                var vehicle = new Vehicle();
                vehicle.Type = inputSplit[0][0].ToString().ToUpper() + inputSplit[0].Substring(1);
                vehicle.Model = inputSplit[1];
                vehicle.Color = inputSplit[2];
                vehicle.Horsepower = int.Parse(inputSplit[3]);
                vehicleList.Add(vehicle);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Close the Catalogue")
            {
                var vehicle = vehicleList.Where(x => x.Model == input).First();
                Console.WriteLine($"Type: {vehicle.Type}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                input = Console.ReadLine();
            }
            if (vehicleList.Where(x => x.Type == "Car").Count() > 0)
                Console.WriteLine($"Cars have average horsepower of: {vehicleList.Where(x => x.Type == "Car").Select(x => x.Horsepower).Average():F2}.");
            else Console.WriteLine($"Cars have average horsepower of: 0.00.");
            if (vehicleList.Where(x => x.Type == "Truck").Count() > 0)
                Console.WriteLine($"Trucks have average horsepower of: {vehicleList.Where(x => x.Type == "Truck").Select(x => x.Horsepower).Average():F2}.");
            else Console.WriteLine($"Trucks have average horsepower of: 0.00.");
        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
}