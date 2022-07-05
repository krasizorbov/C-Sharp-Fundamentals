using System;
using System.Linq;
using System.Collections.Generic;
namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|').ToArray();
            int health = 100;
            int coins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] data = rooms[i].Split().ToArray();

                string first = data[0];
                int second = int.Parse(data[1]);

                if (first == "potion")
                {
                    int initialHealth = health;
                    health += second;
                    if (health > 100)
                    {
                        Console.WriteLine($"You healed for {100 - initialHealth} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");

                    }
                    else
                    {
                        Console.WriteLine($"You healed for {second} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (first == "chest")
                {
                    coins += second;
                    Console.WriteLine($"You found {second} coins.");
                }
                else
                {
                    health -= second;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {first}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {first}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
