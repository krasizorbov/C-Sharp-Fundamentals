using System;

public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string nReversed = Reverse(s);
        Console.WriteLine(nReversed);
    }
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}