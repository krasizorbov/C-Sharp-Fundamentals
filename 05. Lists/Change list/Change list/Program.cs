using System;
using System.Linq;
using System.Collections.Generic;

namespace Change_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();

            while (true)
            {
                if (input[0].ToLower() == "end")
                {
                    break;
                }
                else if (input[0] == "Delete")
                {
                    myList.RemoveAll(x => x.Equals(int.Parse(input[1])));
                }
                else if (input[0] == "Insert")
                {
                    myList.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                input = Console.ReadLine().Split();
            }
            Console.Write(string.Join(" ", myList));
        }
    }
}
