using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {

                    }
                    else
                    {
                        if (j != i)
                        {
                            counter++;
                        }    
                    }
                }
                if (counter == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
