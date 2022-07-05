using System;

public class Program
{
    public static void Main()
    {
        String input = Console.ReadLine();
        String[] divided = input.Split('>');

        int explosionStrength = 0;
        int remainingExplosionStrength = 0;
        for (int i = 1; i < divided.Length; i++)
        {
            explosionStrength = int.Parse("" + divided[i][0]) + remainingExplosionStrength;
            remainingExplosionStrength = explosionStrength - divided[i].Length;

            if (explosionStrength > divided[i].Length)
                explosionStrength = divided[i].Length;

            divided[i] = divided[i].Substring(explosionStrength);
            if (remainingExplosionStrength < 0)
                remainingExplosionStrength = 0;
        }

        String result = String.Join(">", divided);
        Console.WriteLine(result);
    }
}