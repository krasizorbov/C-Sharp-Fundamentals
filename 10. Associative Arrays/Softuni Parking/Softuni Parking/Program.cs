using System;
using System.Linq;
using System.Collections.Generic;

namespace Softuni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "register")
                {
                    string name = input[1];
                    string plate = input[2];

                    if (parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                    else
                    {
                        parking.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                }
                else if (input[0] == "unregister")
                {
                    string name = input[1];
                    if (!parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        parking.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var item in parking)
            {

                Console.WriteLine("{0} => {1}",item.Key, item.Value);
            }
        }
    }
}
