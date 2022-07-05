using System;

namespace Middle_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string result = MiddleCharacters(word);
            Console.WriteLine(result);

        }

        static string MiddleCharacters(string word)
        {
            if (word.Length % 2 == 0)
            {
                return word[(word.Length / 2) - 1].ToString() + word[word.Length / 2].ToString();
            }
            else
            {
                return word[word.Length / 2].ToString();
            }
        }
    }
}
