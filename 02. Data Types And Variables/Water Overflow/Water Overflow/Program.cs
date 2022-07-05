using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum = sum + input;
                
                if (sum > 255)
                {
                    sum = sum - input;
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    total = total + input;
                }
            }
            Console.WriteLine(total);
        }
    }
}
