using System;

namespace Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int spirit = 0;
            int total = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity = quantity + 2;
                }
                if (i % 2 == 0)
                {
                    total = total + quantity * 2;
                    spirit = spirit + 5;
                }
                if (i % 3 == 0)
                {
                    total = total + quantity * 8;
                    spirit = spirit + 13;
                }
                if (i % 5 == 0)
                {
                    total = total + quantity * 15;
                    spirit = spirit + 17;
                    if (i % 3 == 0)
                    {
                        spirit = spirit + 30;
                    }
                }
                if (i % 10 == 0)
                {
                    spirit = spirit - 20;
                    total = total + 23;
                    if (days == i)
                    {
                        spirit = spirit - 30;
                    }
                }   
            }
            Console.WriteLine($"Total cost: {total}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
