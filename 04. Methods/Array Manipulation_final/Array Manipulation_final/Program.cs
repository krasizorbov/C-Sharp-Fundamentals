using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
        while (true)
        {
            string[] input = Console.ReadLine().Split();
            if (input[0] == "end")
            {
                break;
            }
            if (input[0] == "exchange")
            {
                int index = int.Parse(input[1]);
                if (index < 0 || index >= arr.Count)
                {
                    Console.WriteLine("Invalid index");
                    continue;
                }
                List<int> firstHalf = arr.Take(index + 1).ToList();
                arr.RemoveRange(0, index + 1);
                arr = arr.Concat(firstHalf).ToList();
            }
            else if (input[0] == "max" || input[0] == "min")
            {
                int rest = 0;
                if (input[1] == "odd")
                {
                    rest = 1;
                }
                List<int> temp = new List<int>(arr);
                while (true)
                {
                    int num = 0;
                    if (input[0] == "min")
                    {
                        num = temp.Min();
                    }
                    else
                    {
                        num = temp.Max();
                    }
                    if (num % 2 == rest)
                    {
                        Console.WriteLine(arr.LastIndexOf(num));
                        break;
                    }
                    temp.Remove(num);
                    if (temp.Count == 0)
                    {
                        Console.WriteLine("No matches");
                        break;
                    }
                }
            }
            else if (input[0] == "first")
            {
                int count = int.Parse(input[1]);
                if (count > arr.Count)
                {
                    Console.WriteLine("Invalid count");
                    continue;
                }
                int rest = input[2] == "odd" ? 1 : 0;
                Console.Write("[");
                bool isFirst = true;
                for (int a = 0; a < arr.Count; a++)
                {
                    if (arr[a] % 2 == rest)
                    {
                        if (isFirst == false)
                        {
                            Console.Write(", ");
                        }
                        isFirst = false;
                        Console.Write(arr[a]);
                        count--;
                        if (count == 0)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("]");
            }
            else if (input[0] == "last")
            {
                int count = int.Parse(input[1]);
                if (count > arr.Count)
                {
                    Console.WriteLine("Invalid count");
                    continue;
                }
                int rest = input[2] == "odd" ? 1 : 0;
                List<int> temp = new List<int>();
                for (int a = arr.Count - 1; a >= 0; a--)
                {
                    if (arr[a] % 2 == rest)
                    {
                        temp.Add(arr[a]);
                        count--;
                        if (count == 0)
                        {
                            break;
                        }
                    }
                }
                temp.Reverse();
                Console.WriteLine("[" + string.Join(", ", temp) + "]");
            }
        }
        Console.Write("[" + string.Join(", ", arr) + "]");
    }
}
