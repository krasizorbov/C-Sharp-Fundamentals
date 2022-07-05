using System;
using System.Linq;
using System.Collections.Generic;

namespace Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            

            while (input != "END")
            {
                string[] data = input.Split().ToArray();

                string word = data[0];
                
                

                if (word == "Change")
                {
                    int first = int.Parse(data[1]);
                    int second = int.Parse(data[2]);
                    if (numbers.Contains(first))
                    {
                        int indexFirst = numbers.IndexOf(first);
                        numbers[indexFirst] = second;
                        
                    }
                }
                else if (word == "Hide")
                {
                    int first = int.Parse(data[1]);
                    if (numbers.Contains(first))
                    {
                        numbers.Remove(first);
                    }
                }
                else if (word == "Switch")
                {
                    int first = int.Parse(data[1]);
                    int second = int.Parse(data[2]);
                    if (numbers.Contains(first) && numbers.Contains(second))
                    {
                        int indexFirst = numbers.IndexOf(first);
                        int indexSecond = numbers.IndexOf(second);

                        numbers[indexFirst] = second;
                        numbers[indexSecond] = first;
                    }
                }
                else if (word == "Insert")
                {
                    int first = int.Parse(data[1]);
                    int second = int.Parse(data[2]);
                    if (first >= 0 && first < numbers.Count)
                    {
                       
                        numbers.Insert(first + 1, second);
  
                    }
                }
                else if (word == "Reverse")
                {
                    numbers.Reverse();
                }

                input = Console.ReadLine();
            }//loop ends here.

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
