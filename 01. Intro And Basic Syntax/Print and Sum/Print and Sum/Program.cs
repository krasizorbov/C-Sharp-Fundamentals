using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = num1; i <= num2; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
