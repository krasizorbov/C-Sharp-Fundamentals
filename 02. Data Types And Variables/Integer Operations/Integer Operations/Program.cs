using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int div = sum / num3;
            int result = div * num4;
            Console.WriteLine(result);

        }
    }
}
