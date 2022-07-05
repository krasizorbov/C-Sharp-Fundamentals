using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking_factory
{
    class Program
    {
        static void Main(string[] args)
        {

            int currantAvQuality = 0;
            int maxQuality = int.MinValue;
            int maxAvQuality = int.MinValue;
            int bestBatchIndex = -1;
            int currantBatchIndex = -1; ;
            int minLenght = 0;
            List<string> batches = new List<string>();
            while (true)

            {
                string command = Console.ReadLine();
                if (command == "Bake It!")
                {
                    break;
                }
                else
                {
                    int currantBatchQuality = 0;
                    currantBatchIndex++;
                    batches.Add(command);
                    string[] batchNumbers = command.Split('#').ToArray();
                    for (int i = 0; i < batchNumbers.Length; i++)
                    {
                        currantBatchQuality += int.Parse(batchNumbers[i]);
                    }
                    currantAvQuality = currantBatchQuality / batchNumbers.Length;
                    if (currantBatchQuality > maxQuality)
                    {
                        maxQuality = currantBatchQuality;
                        bestBatchIndex = currantBatchIndex;
                        minLenght = batchNumbers.Length;
                        maxAvQuality = currantAvQuality;
                    }
                    else if (currantBatchQuality == maxQuality)
                    {
                        if (currantAvQuality > maxAvQuality)
                        {
                            maxAvQuality = currantAvQuality;
                            bestBatchIndex = currantBatchIndex;
                            minLenght = batchNumbers.Length;
                        }
                        else if (currantAvQuality == maxAvQuality)
                        {
                            if (batchNumbers.Length < minLenght)
                            {
                                maxAvQuality = currantAvQuality;
                                bestBatchIndex = currantBatchIndex;
                                minLenght = batchNumbers.Length;
                            }
                        }
                    }
                }
            }
            string[] bestBatchNumbers = batches[bestBatchIndex].Split('#').ToArray();
            Console.WriteLine($"Best Batch quality: {maxQuality}");
            Console.WriteLine(string.Join(" ", bestBatchNumbers));
        }
    }
}