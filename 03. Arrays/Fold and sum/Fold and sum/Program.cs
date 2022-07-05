using System;
using System.Collections.Generic;
using System.Linq;

namespace Fold_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] third = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = third.Length / 4;

            //Taking the indexes that i need only with Take and Reverse methods.
            int[] first = third.Take(n).ToArray();
            int[] second = third.Reverse().Take(third.Length - (third.Length - n)).Reverse().ToArray();

            //Arrays are reversed here.
            Array.Reverse(first);
            Array.Reverse(second);

            //Creating a new array and combining first and second arrays together.
            var fourth = new int[first.Length + second.Length];
            first.CopyTo(fourth, 0);
            second.CopyTo(fourth, first.Length);

            List<int> myList = new List<int>();

            for (int i = n; i < third.Length - n; i++)
            {
                myList.Add(third[i]);
            }
            int[] six = myList.ToArray();

            for (int i = 0; i < n+n; i++)
            {
                Console.Write(fourth[i] + six[i] + " ");
            }
        }
    }
}
