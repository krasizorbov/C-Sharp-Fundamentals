using System;
using System.Linq;
using System.Collections.Generic;

namespace AM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    break;
                }
                else
                {
                    if (input[0] == "exchange")
                    {
                        int index = int.Parse(input[1]);
                        if (index < 0 || index >= arr.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        else
                        {
                            List<int> temp = new List<int>();
                            temp = arr.Take(index + 1).ToList();
                            arr.RemoveRange(0, index + 1);
                            arr = arr.Concat(temp).ToList();
                        }
                    }
                    else if (input[0] == "max")
                    {
                        if (input[1] == "even")
                        {
                            List<int> temp = new List<int>();
                            int counter = 0;
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i] % 2 == 0)
                                {
                                    temp.Add(arr[i]);
                                }
                                else
                                {
                                    counter++;
                                }
                            }
                            if (counter == arr.Count)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                int index = temp.Max();
                                Console.WriteLine(arr.LastIndexOf(index));
                            } 
                        }
                        else if (input[1] == "odd")
                        {
                            List<int> temp = new List<int>();
                            int counter = 0;
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i] % 2 != 0)
                                {
                                    temp.Add(arr[i]);
                                }
                                else
                                {
                                    counter++;
                                }
                            }
                            if (counter == arr.Count)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                int index = temp.Max();
                                Console.WriteLine(arr.LastIndexOf(index));
                            }
                        }
                    }
                    else if (input[0] == "min")
                    {
                        if (input[1] == "even")
                        {
                            List<int> temp = new List<int>();
                            int counter = 0;
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i] % 2 == 0)
                                {
                                    temp.Add(arr[i]);
                                }
                                else
                                {
                                    counter++;
                                }
                            }
                            if (counter == arr.Count)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                int index = temp.Min();
                                Console.WriteLine(arr.LastIndexOf(index));
                            }
                        }
                        else if (input[1] == "odd")
                        {
                            List<int> temp = new List<int>();
                            int counter = 0;
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i] % 2 != 0)
                                {
                                    temp.Add(arr[i]);
                                }
                                else
                                {
                                    counter++;
                                }
                            }
                            if (counter == arr.Count)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                int index = temp.Min();
                                Console.WriteLine(arr.LastIndexOf(index));
                            }
                        }
                    }
                    else if (input[0] == "first")
                    {
                        int count = int.Parse(input[1]);
                        if (input[2] == "even")
                        {
                            if (count > arr.Count || count < 0)
                            {
                                Console.WriteLine("Invalid count");
                                continue;
                            }
                            else
                            {
                                List<int> temp = new List<int>();
                                for (int i = 0; i < arr.Count; i++)
                                {  
                                    if (arr[i] % 2 == 0)
                                    {
                                        temp.Add(arr[i]);
                                        if (count == temp.Count)
                                        {
                                            break;
                                        }
                                    }
                                }
                                if (temp.Count == 0)
                                {
                                    Console.WriteLine("[]");
                                }
                                else if (temp.Count == 1)
                                {
                                    Console.WriteLine($"[{temp[0]}]");
                                }
                                else if (temp.Count > 1)
                                {
                                    Console.WriteLine("[" + string.Join(", ",temp.Take(temp.Count)) + "]");
                                }
                            }
                        }
                        else if (input[2] == "odd")
                        {
                            if (count > arr.Count || count < 0)
                            {
                                Console.WriteLine("Invalid count");
                                continue;
                            }
                            else
                            {
                                List<int> temp = new List<int>();
                                for (int i = 0; i < arr.Count; i++)
                                {
                                    if (arr[i] % 2 != 0)
                                    {
                                        temp.Add(arr[i]);
                                        if (count == temp.Count)
                                        {
                                            break;
                                        }
                                    }
                                }
                                if (temp.Count == 0)
                                {
                                    Console.WriteLine("[]");
                                }
                                else if (temp.Count == 1)
                                {
                                    Console.WriteLine($"[{temp[0]}]");
                                }
                                else if (temp.Count > 1)
                                {
                                    Console.WriteLine("[" + string.Join(", ", temp.Take(temp.Count)) + "]");
                                }
                            }
                        }
                    }
                    else if (input[0] == "last")
                    {
                        int count = int.Parse(input[1]);
                        if (input[2] == "even")
                        {
                            if (count > arr.Count || count < 0)
                            {
                                Console.WriteLine("Invalid count");
                                continue;
                            }
                            else
                            {
                                List<int> temp = new List<int>();
                                for (int i = arr.Count - 1; i > -1; i--)
                                {
                                    if (arr[i] % 2 == 0)
                                    {
                                        temp.Add(arr[i]);
                                        if (count == temp.Count)
                                        {
                                            break;
                                        }
                                    }
                                }
                                temp.Reverse();
                                if (temp.Count == 0)
                                {
                                    Console.WriteLine("[]");
                                }
                                else if (temp.Count == 1)
                                {
                                    Console.WriteLine($"[{temp[0]}]");
                                }
                                else if (temp.Count > 1)
                                {
                                    Console.WriteLine("[" + string.Join(", ", temp.Take(temp.Count)) + "]");
                                }
                            }
                        }
                        else if (input[2] == "odd")
                        {
                            if (count > arr.Count || count < 0)
                            {
                                Console.WriteLine("Invalid count");
                                continue;
                            }
                            else
                            {
                                List<int> temp = new List<int>();
                                for (int i = arr.Count - 1; i > -1; i--)
                                {
                                    if (arr[i] % 2 != 0)
                                    {
                                        temp.Add(arr[i]);
                                        if (count == temp.Count)
                                        {
                                            break;
                                        }
                                    }
                                }
                                temp.Reverse();
                                if (temp.Count == 0)
                                {
                                    Console.WriteLine("[]");
                                }
                                else if (temp.Count == 1)
                                {
                                    Console.WriteLine($"[{temp[0]}]");
                                }
                                else if (temp.Count > 1)
                                {
                                    
                                    Console.WriteLine("[" + string.Join(", ", temp.Take(temp.Count)) + "]");
                                }
                            }
                        }
                    }
                }
            }// while loop ends here.
            Console.Write("[" + string.Join(", ", arr) + "]");
        }//Main method ends here.
    }
}
