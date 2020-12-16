using System;
using System.Linq;

namespace _7.Max_Sequence_of_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxSequence = 1;
            int maxSequenceStartingIndex = 0;
            int maxSequenceEndingIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int sequenceCounter = 1;
                int endingIndex = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        sequenceCounter++;
                        endingIndex = j;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequenceCounter > maxSequence)
                {
                    maxSequence = sequenceCounter;
                    maxSequenceStartingIndex = i;
                    maxSequenceEndingIndex = endingIndex;
                }
            }
            for (int h = maxSequenceStartingIndex; h <= maxSequenceEndingIndex; h++)
            {
                Console.Write(arr[h] + " ");
            }
        }
    }
}
