using System;

namespace Pyramid_Refactory
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());

            double width = double.Parse(Console.ReadLine());

            double hight = double.Parse(Console.ReadLine());

            double volume = (length * width * hight) / 3;

            Console.WriteLine("Length: Width: Height: Pyramid Volume: {0:F2}", volume);
        }
    }
}
