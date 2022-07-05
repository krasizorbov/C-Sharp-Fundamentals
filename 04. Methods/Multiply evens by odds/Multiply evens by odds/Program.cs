using System;
using System.Linq;
using System.Collections.Generic;
namespace Multiply_evens_by_odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<int> listOfInts = new List<int>();
            while (Math.Abs(num) > 0)
            {
                listOfInts.Add(Math.Abs(num) % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            int[]numbers = listOfInts.ToArray();
            int sumEven = GetSumOfEvenDigits(numbers);
            int sumOdd = GetSumOfOddDigits(numbers);
            int result = GetMultipleOfEvenAndOdds(sumEven, sumOdd);
            Console.WriteLine(result);

        }
        static int GetMultipleOfEvenAndOdds(int sumEven, int sumOdd)
        {
            return sumEven * sumOdd;
        }

        static int GetSumOfEvenDigits(int[]numbers)
        {
            int sumEven = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven = sumEven + Math.Abs(numbers[i]);
                }
            }
            return sumEven;
        }

        static int GetSumOfOddDigits(int[]numbers)
        {
            int sumOdd = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    sumOdd = sumOdd + Math.Abs(numbers[i]);
                }
            }
            return sumOdd;
        }
    }
}
