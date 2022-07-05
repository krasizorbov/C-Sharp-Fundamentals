using System;

namespace Sum_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] arr = numbers.Split(' ');
            int[] num = Array.ConvertAll(arr, int.Parse);
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    sum += num[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
