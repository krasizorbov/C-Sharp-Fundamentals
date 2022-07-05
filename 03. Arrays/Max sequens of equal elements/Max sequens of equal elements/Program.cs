using System;
using System.Linq;

namespace P06_MaxSequenceOfEqualElementsV2
{
    class P06_MaxSequenceOfEqualElementsV2
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
          
            int lenght = 1;
            int startIndex = 0;
            int maxLenth = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                }
                if (lenght > maxLenth)
                {
                    maxLenth = lenght;
                    startIndex = i - lenght + 1;
                }
            }

            int[] output = input.Skip(startIndex).Take(maxLenth).ToArray();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}