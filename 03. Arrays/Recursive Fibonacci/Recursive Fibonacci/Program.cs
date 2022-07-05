using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    arr[i] = 1;
                }
                else if (i == 1)
                {
                    arr[i] = 1;
                }
                else
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }
            }
            Console.WriteLine(arr[n - 1]);
        }
    }
}
