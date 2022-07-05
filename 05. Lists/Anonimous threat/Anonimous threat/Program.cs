using System;
using System.Linq;
using System.Collections.Generic;

namespace Anonimous_threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "3:1")
                {
                    break;
                }
                int startIndex = int.Parse(command[1]);
                int endIndex = int.Parse(command[2]);
                string word = string.Empty;
                if (startIndex < 0 || startIndex > input.Count)
                {
                    startIndex = 0;
                }
                if (endIndex < 0 || endIndex > input.Count - 1)
                {
                    endIndex = input.Count - 1;
                }
                if (command[0] == "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        word = word + input[i];
                    }
                    input.RemoveRange(startIndex, endIndex - startIndex + 1);
                    input.Insert(startIndex, word);
                }
                else if (command[0] == "divide")
                {
                    List<string> divided = new List<string>();
                    int division = int.Parse(command[2]);
                    string devidedWord = input[startIndex];
                    input.RemoveAt(startIndex);
                    int parts = devidedWord.Length / division;
                    for (int i = 0; i < division; i++)
                    {
                        if (i == division - 1)
                        {
                            divided.Add(devidedWord.Substring(i * parts));
                        }
                        else
                        {
                            divided.Add(devidedWord.Substring(i * parts, parts));
                        }
                    }
                    input.InsertRange(startIndex, divided);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
