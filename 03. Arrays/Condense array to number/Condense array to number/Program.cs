using System;

namespace Condense_array_to_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string[] arr = number.Split(' ');
            int[] num = Array.ConvertAll(arr, int.Parse);

            while (num.Length > 1)
            {
                int[] condenced = new int[num.Length - 1];
                for (int i = 0; i < num.Length - 1; i++)
                {
                    condenced[i] = num[i] + num[i + 1];
                }
                num = condenced;
            }
            Console.WriteLine(num[0]);  
        }
    }
}
