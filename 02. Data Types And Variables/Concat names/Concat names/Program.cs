using System;

namespace Concat_names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string secondname = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{firstname}{delimiter}{secondname}");
        }
    }
}
