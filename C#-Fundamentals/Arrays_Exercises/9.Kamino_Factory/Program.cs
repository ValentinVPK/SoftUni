using System;
using System.Linq;

namespace _9.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int length = int.Parse(Console.ReadLine());
            int[] maxSequenceArray = new int[length];
            int maxSequenceArrayLength = int.MinValue;
            int maxSequenceArrayIndex = int.MinValue;
            int maxSequenceArraySum = int.MinValue;
            int maxSequenceArrayNumber = 0;
            int index = 1;


            while ((input = Console.ReadLine()) != "Clone them!")
            {

                int[] array = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentLength = int.MinValue, currentIndex = int.MinValue, currentSubLength = 0, currentSubIndex = 0;
                bool isOne = false;

                for (int i = 0; i < length; i++)
                {
                    if (array[i] == 1 && isOne)
                    {
                        currentSubLength++;
                    }
                    else if (array[i] == 1)
                    {
                        isOne = true;
                        currentSubIndex = i;
                        currentSubLength = 1;
                    }
                    else if (array[i] == 0 && isOne)
                    {
                        if (currentSubLength > currentLength)
                        {
                            currentLength = currentSubLength;
                            currentIndex = currentSubIndex;
                        }
                        isOne = false;
                        currentSubLength = 0;
                        currentSubIndex = 0;
                    }
                }
                if (isOne)
                {
                    if (currentSubLength > currentLength)
                    {
                        currentLength = currentSubLength;
                        currentIndex = currentSubIndex;
                    }
                }
                if (currentLength > maxSequenceArrayLength)
                {
                    maxSequenceArrayLength = currentLength;
                    maxSequenceArrayIndex = currentIndex;
                    maxSequenceArraySum = array.Sum();
                    maxSequenceArray = array;
                    maxSequenceArrayNumber = index;
                }
                else if (currentLength == maxSequenceArrayLength)
                {
                    if (currentIndex < maxSequenceArrayIndex)
                    {
                        maxSequenceArrayLength = currentLength;
                        maxSequenceArrayIndex = currentIndex;
                        maxSequenceArraySum = array.Sum();
                        maxSequenceArray = array;
                        maxSequenceArrayNumber = index;
                    }
                    else if (array.Sum() > maxSequenceArraySum)
                    {
                        maxSequenceArrayLength = currentLength;
                        maxSequenceArrayIndex = currentIndex;
                        maxSequenceArraySum = array.Sum();
                        maxSequenceArray = array;
                        maxSequenceArrayNumber = index;
                    }
                }
                index++;
            }

            Console.WriteLine($"Best DNA sample {maxSequenceArrayNumber} with sum: {maxSequenceArraySum}.");
            Console.WriteLine(string.Join(" ", maxSequenceArray));
        }
    }
}
