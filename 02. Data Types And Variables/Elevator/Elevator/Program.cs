using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int div = numPeople / elevatorCapacity;
            //int result = (int)Math.Ceiling((double)numPeople / elevatorCapacity);
            int result = numPeople % elevatorCapacity;
            if (div == 0)
            {
                Console.WriteLine(div + 1);
            }
            else if (numPeople % elevatorCapacity == 0)
            {
                Console.WriteLine(div);
            }
            else if (numPeople % elevatorCapacity != 0)
            {
                Console.WriteLine(result + div +1);
            }
        }
    }
}
