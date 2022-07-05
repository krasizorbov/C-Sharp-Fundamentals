using System;

namespace Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[3];
            for (int i = 0; i < 3; i++)
            {
                char symb = char.Parse(Console.ReadLine());
                arr[i] = symb;
            }
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
