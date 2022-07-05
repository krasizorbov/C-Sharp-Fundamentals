using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Mixed_up_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int firstList = 0;
            int secondList = 0;

            if (first.Count > second.Count)
            {
                firstList = 1;
            }
            else if (first.Count < second.Count)
            {
                secondList = 1;
            }
            if (firstList == 1)
            {
                for (int i = 0; i < first.Count - 2; i++)
                {
                    
                    for (int j = second.Count - i - 1; j >= 0; j--)
                    {
                        result.Add(first[i]);
                        result.Add(second[j]);
                        break;
                    } 
                }
            }
            else if (secondList == 1)
            {
                for (int i = 0; i < first.Count; i++)
                {

                    for (int j = second.Count - i - 1; j >= 2; j--)
                    {
                        result.Add(first[i]);
                        result.Add(second[j]);
                        break;
                    }
                }
            }
            List<int> final = new List<int>();
            if (firstList == 1)
            {
                if (first[first.Count - 2] < first[first.Count - 1])
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i] > first[first.Count - 2] && result[i] < first[first.Count - 1])
                        {
                            final.Add(result[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i] > first[first.Count - 1] && result[i] < first[first.Count - 2])
                        {
                            final.Add(result[i]);
                        }
                    }
                }
            }
            else if (secondList == 1)
            {
                if (second[0] < second[1])
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i] > second[0] && result[i] < second[1])
                        {
                            final.Add(result[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i] > second[1] && result[i] < second[0])
                        {
                            final.Add(result[i]);
                        }
                    }
                }
            }
            final.Sort();
            Console.WriteLine(string.Join(" ", final));
        }
    }
}
