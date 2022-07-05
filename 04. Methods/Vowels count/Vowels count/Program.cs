using System;

namespace Vowels_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int result = CountVowels(word);
            Console.WriteLine(result);
        }

        static int CountVowels(string word)
        {
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'A' || word[i] == 'e' || word[i] == 'E' || word[i] == 'i' || word[i] == 'I' || word[i] == 'o' || word[i] == 'O' || word[i] == 'u' || word[i] == 'U')
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
