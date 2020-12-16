using System;
using System.Linq;
using System.Collections.Generic;

namespace _15_Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] len = new int[seq.Length];
            int[] prev = new int[seq.Length];

            int bestIndex = CalculateLongestIncreasingSubsequence(seq, len, prev);

            PrintLongestIncreasingSubsequence(seq, prev, bestIndex);
        }
        private static int CalculateLongestIncreasingSubsequence(int[] seq, int[] len, int[] prev)
        {

            int maxIndex = 0;
            int maxLen = 0;
            for (int x = 0; x < seq.Length; x++)
            {
                len[x] = 1;
                prev[x] = -1;
                for (int i = 0; i < x; i++)
                {
                    if (seq[i] < seq[x] && len[i] + 1 > len[x])
                    {
                        len[x] = len[i] + 1;
                        prev[x] = i;
                    }
                }
                if (len[x] > maxLen)
                {
                    maxLen = len[x];
                    maxIndex = x;
                }
            }
            return maxIndex;
        }

        static void PrintLongestIncreasingSubsequence(int[] seq, int[] prev, int index)
        {
            List<int> lis = new List<int>();
            while (index != -1)
            {
                lis.Add(seq[index]);
                index = prev[index];
            }
            lis.Reverse();
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
