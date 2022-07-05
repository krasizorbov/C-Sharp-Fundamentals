using System;

namespace Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int offset;
            int indexLetter;
            char letter;
            string message = string.Empty;

            for (int i = 1; i <= a; i++)
            {
                string n = Console.ReadLine();
                int length = n.Length;
                int digit = n[length - 1] - '0';
                if (digit == 8 || digit == 9)
                {
                    offset = (digit - 2) * 3;
                    offset = offset + 1;
                    indexLetter = offset + length - 1;
                    letter = (char)(indexLetter + 97);
                }
                else if (digit == 0)
                {
                    offset = (digit - 2) * 3;
                    indexLetter = offset + length - 1;
                    letter = (char)(32);
                }
                else
                {
                    offset = (digit - 2) * 3;
                    indexLetter = offset + length - 1;
                    letter = (char)(indexLetter + 97);
                }
                message = message + letter;
            }
            Console.WriteLine(message); 
        }
    }
}
