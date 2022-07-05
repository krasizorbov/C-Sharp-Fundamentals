using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    public static void Main()
    {
        int amountSnowballs = int.Parse(Console.ReadLine());
        int i = 0;
        BigInteger snowballValue = 0;
        int snowballSnow = 0;
        int snowballTime = 0;
        int snowballQuality = 0;
        BigInteger[] arr = new BigInteger[amountSnowballs];
        double[] first = new double[amountSnowballs];
        double[] second = new double[amountSnowballs];
        double[] third = new double[amountSnowballs];

        for (i = 0; i < amountSnowballs; i++)
        {
            snowballSnow = int.Parse(Console.ReadLine());
            snowballTime = int.Parse(Console.ReadLine());
            snowballQuality = int.Parse(Console.ReadLine());
            BigInteger divisiont = (BigInteger)(snowballSnow / snowballTime);
            snowballValue = BigInteger.Pow(divisiont, snowballQuality);
            arr[i] = snowballValue;
            first[i] = snowballSnow;
            second[i] = snowballTime;
            third[i] = snowballQuality;

        }
        BigInteger maxValue = arr.Max();
        int maxIndex = Array.IndexOf(arr,maxValue);

        Console.WriteLine("{0} : {1} = {2} ({3})", first[maxIndex], second[maxIndex], maxValue, third[maxIndex]);
    }
}
