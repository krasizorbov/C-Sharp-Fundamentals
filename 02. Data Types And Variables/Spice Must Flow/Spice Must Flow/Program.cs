using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {

            long mine = long.Parse(Console.ReadLine());
            long harvest = 0;
            long days = 0;

            if (mine >= 100)
            {
                do
                {
                    days++;
                    harvest = (harvest + mine) - 26;
                    mine = mine - 10;
                } while (mine >= 100);
                harvest = harvest - 26;
                Console.WriteLine(days);
                Console.WriteLine(harvest);
            }
            else
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
        }
    }
}
