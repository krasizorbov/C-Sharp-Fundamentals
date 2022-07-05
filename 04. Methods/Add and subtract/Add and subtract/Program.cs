using System;

namespace Add_and_subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = Sum(num1, num2);
            int result = Subtract(sum, num3);
            Console.WriteLine(result);

        }

        static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        static int Subtract(int sum, int num3)
        {
            int result = sum - num3;
            return result;
        }
    }
}
