using System;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string[] arr1 = first.Split(' ');
            string[] arr2 = second.Split(' ');
            int[] my1 = Array.ConvertAll(arr1, int.Parse);
            int[] my2 = Array.ConvertAll(arr2, int.Parse);
            bool isTrue = false;
            int sum = 0;
            int myIndex = 0;
            for (int i = 0; i < my1.Length; i++)
            {
                if (my1[i] == my2[i])
                {
                    isTrue = true;
                    sum += my1[i];
                }
                else
                {
                    isTrue = false;
                    myIndex = i;
                    break;
                }
            }
            if (isTrue == true)
            {
                Console.WriteLine("Arrays are identical. Sum: {0}", sum);
            }
            else
            {
                Console.WriteLine("Arrays are not identical. Found difference at {0} index", myIndex);
            }
        }
    }
}
