using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Extract_File_Name
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] path = Console.ReadLine().Split('\\');
            string fileName = "";
            for (int i = path.Length - 1; i >= 0; i--)
            {
                fileName = path[i];
                break;
            }
            string[] output = fileName.Split('.').ToArray();
            Console.WriteLine($"File name: {output[0]}");
            Console.WriteLine($"File extension: {output[1]}");
        }
    }
}
