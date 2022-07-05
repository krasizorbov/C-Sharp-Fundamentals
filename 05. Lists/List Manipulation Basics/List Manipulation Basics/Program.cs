using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    myList.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    myList.Remove(int.Parse(input[1]));
                }
                else if (input[0] == "RemoveAt")
                {
                    myList.RemoveAt(int.Parse(input[1]));
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
