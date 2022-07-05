using System;
using System.Numerics;

namespace Big_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger result = 0; ;
            if (num == 0)
            {
                result = 1;
            }
            else
            {
                result = num;
                for (int i = 1; i < num; i++)
                {
                    result = result * i;
                }
                
            }
            Console.WriteLine(result);
        }
    }
}
