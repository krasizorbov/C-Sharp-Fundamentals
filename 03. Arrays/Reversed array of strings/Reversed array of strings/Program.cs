using System;

namespace Reversed_array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] arr = word.Split(' ');

            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
