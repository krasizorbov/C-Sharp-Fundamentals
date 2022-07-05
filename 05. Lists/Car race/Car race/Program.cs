using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Car_race
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] speedNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lastIndex = speedNumbers.Length - 1;
            int middleIndex = speedNumbers.Length / 2;
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < middleIndex; i++)
            {
                if (speedNumbers[i] == 0)
                {
                    sum1 = sum1 * 0.8;
                }
                else
                {
                    sum1 = sum1 + speedNumbers[i];
                }
            }
            for (int i = lastIndex; i > middleIndex; i--)
            {
                if (speedNumbers[i] == 0)
                {
                    sum2 = sum2 * 0.8;
                }
                else
                {
                    sum2 = sum2 + speedNumbers[i];
                }
            }
            if (sum1 < sum2)
            {
                Console.WriteLine("The winner is left with total time: {0}", sum1);
            }
            else if (sum2 < sum1)
            {
                Console.WriteLine("The winner is right with total time: {0}", sum2);
            }
        }
    }
}
