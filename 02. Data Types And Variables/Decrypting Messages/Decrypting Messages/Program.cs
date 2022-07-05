using System;

namespace Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToadd = int.Parse(Console.ReadLine());
            int charAmount = int.Parse(Console.ReadLine());
            int[] arr = new int[charAmount];

            for (int i = 0; i < charAmount; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                arr[i] = numberToadd + letter;
            }
            foreach (var item in arr)
            {
                Console.Write((char)item);
            }
        }
    }
}
