using System;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }
                string myword = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    myword = myword + word[i];
                }

                Console.WriteLine($"{word} = {myword}");
            }
        }
    }
}
