using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int index1 = first.Count();
            int index2 = second.Count();

            if (index1 < index2)
            {
                for (int i = 0; i < index1; i++)
                {
                    result.Add(first[i]);
                    result.Add(second[i]);
                }
                for (int j = index1; j < index2; j++)
                {
                    result.Add(second[j]);
                }
            }
            else if (index1 > index2)
            {
                for (int i = 0; i < index2; i++)
                {
                    result.Add(first[i]);
                    result.Add(second[i]);
                }
                for (int j = index2; j < index1; j++)
                {
                    result.Add(first[j]);
                }
            }
            else
            {
                for (int i = 0; i < index1; i++)
                {
                    result.Add(first[i]);
                    result.Add(second[i]);
                }
            }
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
