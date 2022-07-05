using System;
using System.Linq;
using System.Collections.Generic;

namespace House_party
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            List<string> myList = new List<string>();
            for (int i = 0; i < times; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[2] == "going!")
                {
                    if (myList.Contains(input[0]))
                    {
                        Console.WriteLine("{0} is already in the list!", input[0]);
                    }
                    else
                    {
                        myList.Add(input[0]);
                    }
                }
                else if (input[2] == "not")
                {
                    if (myList.Contains(input[0]))
                    {
                        myList.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not in the list!", input[0]);
                    }
                }
            }
            foreach (var name in myList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
