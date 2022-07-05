using System;

namespace Combine_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = returnString();
            Console.WriteLine(m);
            
        }
        public static string returnString()
        {
            char[] arr = new char[4];
            arr[0] = 'a';
            arr[1] = 'z';
            arr[2] = 'a';
            arr[3] = 'z';
            // Return new string key
            return new string(arr);
        }
    }
}
