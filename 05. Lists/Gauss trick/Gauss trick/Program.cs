using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = new List<int>();
            int lastIndex = list1.Count;
            int i = 0;
            if (list1.Count % 2 == 0)
            {
                for (i = 0; i < list1.Count / 2; i++)
                {
                    list2.Add(list1[i] + list1[lastIndex - 1 - i]);
                } 
            }
            else if (lastIndex % 2 != 0)
            {
                for (i = 0; i < lastIndex / 2; i++)
                {
                    list2.Add(list1[i] + list1[lastIndex - 1 - i]);
                }
                list2.Add(list1[lastIndex / 2]);
            }

            foreach (var item in list2)
            {
                Console.Write(item + " ");
            }
        }
    }
}
