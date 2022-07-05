using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        //1 4 4 2 8 9 1
        List<int> sequnce = Console.ReadLine().Split().Select(int.Parse).ToList();

        string[] intpit = Console.ReadLine().Split();

        int number = int.Parse(intpit[0]);
        int power = int.Parse(intpit[1]);

        for (int i = 0; i < sequnce.Count; i++)
        {
            if (sequnce[i] == number)
            {
                int left = Math.Max(i - power, 0);

                int right = Math.Min(i + power, sequnce.Count - 1);

                int lenght = right - left + 1;
                sequnce.RemoveRange(left, lenght);
                i = 0;
            }
        }
        Console.WriteLine(sequnce.Sum());
    }

}


