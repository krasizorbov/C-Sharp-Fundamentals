using System;
using System.Linq;
using System.Collections.Generic;

namespace Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] events = Console.ReadLine().Split('|',StringSplitOptions.RemoveEmptyEntries).ToArray();
            int energy = 100;
            int coins = 100;

            for (int i = 0; i < events.Length; i++)
            {
                string[] data = events[i].Split('-',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string first = data[0];
                int second = int.Parse(data[1]);

                if (first == "rest")
                {
                    int initialEnergy = energy;
                    energy += second;
                    if (energy > 100)
                    {
                        
                        Console.WriteLine($"You gained {100 - initialEnergy} energy.");
                        energy = 100;
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                    else if (energy <= 100)
                    {
                        
                        Console.WriteLine($"You gained {second} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                }
                else if (first == "order")
                {
                    energy -= 30;
                    coins += second;

                    if (energy >= 0)
                    {
                        
                        Console.WriteLine($"You earned {second} coins.");
                    }
                    else
                    {
                        
                        coins -= second;

                        energy += 80;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    coins -= second;
                    if (coins > 0)
                    {
                        Console.WriteLine($"You bought {first}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {first}.");
                        return;
                    }
                }


            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
