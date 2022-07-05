using System;

namespace Characters_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string word = CharactersRange(first, second);
            Console.WriteLine(word);

        }

        static string CharactersRange(char first, char second)
        {
            string word = string.Empty;
            if (first < second)
            {
                for (int i = first + 1; i < second; i++)
                {
                    word = word + (char)i + " ";
                }
            }
            else
            {
                for (int i = second + 1; i < first; i++)
                {
                    word = word + (char)i + " ";
                }
            }
            
            return word;
        }
    }
}
