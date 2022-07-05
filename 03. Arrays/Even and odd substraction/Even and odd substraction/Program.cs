using System;

namespace Even_and_odd_substraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] arr = numbers.Split(' ');
            int[] num = Array.ConvertAll(arr, int.Parse);
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    evenSum += num[i];
                }
                else
                {
                    oddSum += num[i];
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
