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
            List<int> copy = myList.ToList();
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
                else if (input[0] == "Contains")
                {
                    if (myList.Contains(int.Parse(input[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (input[0] == "PrintEven")
                {
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] % 2 == 0)
                        {
                            Console.Write(myList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (input[0] == "PrintOdd")
                {
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] % 2 != 0)
                        {
                            Console.Write(myList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (input[0] == "GetSum")
                {
                    int sum = myList.Sum();//(x => Convert.ToInt32(x));
                    Console.WriteLine(sum);
                }
                else if (input[0] == "Filter" && input[1] == ">")
                {
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] > int.Parse(input[2]))
                        {
                            Console.Write(myList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (input[0] == "Filter" && input[1] == "<")
                {
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] < int.Parse(input[2]))
                        {
                            Console.Write(myList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (input[0] == "Filter" && input[1] == ">=")
                {
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] >= int.Parse(input[2]))
                        {
                            Console.Write(myList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (input[0] == "Filter" && input[1] == "<=")
                {
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i] <= int.Parse(input[2]))
                        {
                            Console.Write(myList[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                input = Console.ReadLine().Split();
            }
            bool areEqual = myList.SequenceEqual(copy);
            if (!areEqual)
            {
                Console.Write(string.Join(" ", myList));
            }
            
        }
    }
}

