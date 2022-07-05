using System;
using System.Linq;
using System.Collections.Generic;

namespace Santa_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = Console.ReadLine().Split('&').ToList();

            string input = Console.ReadLine();

            while (input != "Finished!")
            {
                string[] arr = input.Split().ToArray();

                if (arr[0] == "Bad")
                {
                    if (!kids.Contains(arr[1]))
                    {
                        kids.Insert(0,arr[1]);
                    }
                }
                if (arr[0] == "Good")
                {
                    if (kids.Contains(arr[1]))
                    {
                        kids.Remove(arr[1]);
                    }
                }
                if (arr[0] == "Rename")
                {
                    if (kids.Contains(arr[1]))
                    {
                        int index = kids.IndexOf(arr[1]);
                        kids[index] = arr[2];
                    }
                }
                if (arr[0] == "Rearrange")
                {
                    if (kids.Contains(arr[1]))
                    {
                        kids.Remove(arr[1]);
                        kids.Add(arr[1]);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", kids));
        }
    }
}
