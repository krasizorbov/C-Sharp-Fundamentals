using System;

namespace Tribunacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(TribunacciSequence(num, numbers, i) + " ");
            }
        }

        static int TribunacciSequence(int num, int[] numbers, int i)
        {
            if (i == 0)
            {
                return numbers[i] = 1;
            }
            else if (i == 1)
            {
                return numbers[i] = 1;
            }
            else if (i == 2)
            {
                return numbers[i] = 2;
            }
            else
            {
                return numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
            }
        }
    }
}
