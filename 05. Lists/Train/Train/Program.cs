using System;
using System.Linq;
using System.Collections.Generic;
namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int passengers = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split();

            while (true)
            {
                if (input[0].ToLower() == "end")
                {
                    break;
                }
                else if (input[0] == "Add")
                {
                    vagons.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < vagons.Count; i++)
                    {
                        if ((int.Parse(input[0]) + vagons[i]) <= passengers)
                        {
                            vagons[i] = vagons[i] + int.Parse(input[0]);
                            break;
                        }
                    }
                }
                input = Console.ReadLine().Split();
            }
            Console.Write(string.Join(" ", vagons));
        }
    }
}
