using System;

namespace Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n,n];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j == 0)
                    {
                        arr[i - 1, j] = 1;
                    }
                    else
                    {
                        arr[i - 1, j] = arr[i - 2, j - 1] + arr[i - 2, j];
                    }
                    Console.Write(arr[i - 1,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
