using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbersOne = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> numbersTwo = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> mixedList = new List<double>();
            double constrainOne = 0;
            double constrainTwo = 0;

            numbersTwo.Reverse();

            int biggerCount = 0;
            if (numbersOne.Count > numbersTwo.Count) biggerCount = numbersOne.Count;
            else biggerCount = numbersTwo.Count;

            for (int i = 0; i < biggerCount; i++)
            {
                if (i >= numbersTwo.Count)
                {
                    constrainOne = numbersOne[i];
                    constrainTwo = numbersOne[i + 1];
                    break;
                }
                else if (i >= numbersOne.Count)
                {
                    constrainOne = numbersTwo[i];
                    constrainTwo = numbersTwo[i + 1];
                    break;
                }
                else
                {
                    mixedList.Add(numbersOne[i]);
                    mixedList.Add(numbersTwo[i]);
                }
            }

            if (constrainOne > constrainTwo)
            {
                double tmpOne = constrainOne;
                double tmpTwo = constrainTwo;

                constrainTwo = tmpOne;
                constrainOne = tmpTwo;
            }

            List<double> resultList = new List<double>();

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > constrainOne && mixedList[i] < constrainTwo)
                {
                    resultList.Add(mixedList[i]);
                }
            }

            resultList.Sort();

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
