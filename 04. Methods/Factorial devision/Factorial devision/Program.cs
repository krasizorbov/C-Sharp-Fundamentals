using System;

namespace Factorial_devision
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = int.Parse(Console.ReadLine());
            long num2 = int.Parse(Console.ReadLine());
            long result1 = FirstFactorial(num1);
            long result2 = SecondFactorial(num2);
            double result = Divide(result1, result2);
            Console.WriteLine($"{result:F2}");
        }

        static long FirstFactorial(long num1)
        {
            if (num1 == 0)
            {
                return 1;
            }
            else
            {
                long result1 = num1;
                for (int i = 1; i < num1; i++)
                {
                    result1 = result1 * i;
                }
                return result1;
            } 
        }

        static long SecondFactorial(long num2)
        {
            if (num2 == 0)
            {
                return 1;
            }
            else
            {
                long result2 = num2;
                for (int i = 1; i < num2; i++)
                {
                    result2 = result2 * i;
                }
                return result2;
            }
        }

        static double Divide(long result1, long result2)
        {
            double result = (double)result1 / (double)result2;
            return result;
        }
    }
}
