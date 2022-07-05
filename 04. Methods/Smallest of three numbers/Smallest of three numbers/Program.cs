using System;
using System.Linq;

namespace Smallest_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int[] numbers = { num1, num2, num3 };
            int result = SmallestNumber(numbers);
            Console.WriteLine(result);
        }

        static int SmallestNumber(int[]numbers)
        {
            return numbers.Min();
        }
    }
}
