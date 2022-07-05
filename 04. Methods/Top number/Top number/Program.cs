using System;

namespace Top_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int a = 0;
            int sum = 0;
            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                a = i;
                while (a != 0)
                {
                    sum += a % 10;
                    a /= 10;
                }
                string n = i.ToString();
                for (int j = 0; j < n.Length; j++)
                {
                    if (n[j] % 2 != 0)
                    {
                        counter++;
                    }
                }
                if (sum % 8 == 0 && counter > 0 )
                {
                    Console.WriteLine(i);
                }
                sum = 0;
                counter = 0;
            }
        }
    }
}
