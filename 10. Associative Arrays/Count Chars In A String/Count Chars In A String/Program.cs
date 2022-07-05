using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Chars_In_A_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Dictionary<char, int> symbols = new Dictionary<char, int>();

            List<char> list = new List<char>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    list.Add(words[i][j]);
                }
            }

            var newList = list.GroupBy(x => x);

            foreach (var item in newList)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Count());
            }
            
        }
    }
}
