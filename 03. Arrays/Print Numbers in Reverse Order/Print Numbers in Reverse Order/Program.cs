using System;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }
            //Array.Sort(arr);
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
