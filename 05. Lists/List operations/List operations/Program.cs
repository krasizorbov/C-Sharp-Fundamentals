using System;
using System.Linq;
using System.Collections.Generic;

namespace List_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();

            while (true)
            {
                if (input[0] == "End")
                {
                    break;
                }
                else if (input[0] == "Add")
                {
                    myList.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    if (int.Parse(input[2]) > myList.Count - 1 || (int.Parse(input[2]) < 0))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        myList.Insert(int.Parse(input[2]), int.Parse(input[1]));
                    } 
                }
                else if (input[0] == "Remove")
                {
                    if (int.Parse(input[1]) > myList.Count - 1 || int.Parse(input[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        myList.RemoveAt(int.Parse(input[1]));
                    }
                }
                else if (input[1] == "left")
                { 
                    for (int i = 0; i < int.Parse(input[2]); i++)
                    {
                        int temp = myList[0];
                        for (int j = 0; j < myList.Count - 1; j++)
                        {
                            myList[j] = myList[j + 1];
                        }
                        myList[myList.Count - 1] = temp;
                    }
                }
                else if (input[1] == "right")
                {
                    for (int i = 0; i < int.Parse(input[2]); i++)
                    {
                        int temp = myList[myList.Count - 1];
                        for (int j = myList.Count - 1; j > 0; j--)
                        {
                            myList[j] = myList[j - 1];
                        }
                        myList[0] = temp;
                    }
                }
                input = Console.ReadLine().Split();
            }
            Console.Write(string.Join(" ", myList));
        }
    }
}
