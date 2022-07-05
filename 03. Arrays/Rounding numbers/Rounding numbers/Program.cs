using System;

namespace Rounding_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] arr = word.Split(' ');
            foreach (var item in arr)
            {
                double num = double.Parse(item);
                Console.WriteLine($"{num} => {num:F0}");
            }
        }
    }
}
