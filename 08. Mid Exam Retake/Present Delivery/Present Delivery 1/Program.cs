
namespace PresentDelivery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            List<int> houses = Console.ReadLine().Split(new[] { '@' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

            int currentIndex = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Merry Xmas!")
                {
                    break;
                }

                string[] command = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Jump")
                {
                    int jumpCount = int.Parse(command[1]);

                    if (currentIndex + jumpCount >= houses.Count)
                    {
                        // start from 0
                        currentIndex = (currentIndex + jumpCount) % houses.Count;
                    }

                    else
                    {
                        currentIndex += jumpCount;
                    }
                    if (houses[currentIndex] == 0)
                    {
                        Console.WriteLine($"House {currentIndex} will have a Merry Christmas.");
                    }

                    else
                    {
                        houses[currentIndex] -= 2;
                    }
                }
            }

            int failedHouses = houses.Where(x => x != 0).Count();

            Console.WriteLine($"Santa's last position was {currentIndex}.");

            if (failedHouses > 0)
            {
                Console.WriteLine($"Santa has failed {failedHouses} houses.");
            }

            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}