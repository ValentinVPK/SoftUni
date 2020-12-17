using System;

namespace VtoraZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] twoStrings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            string smallerElemet;
            string biggerElement;

            if(twoStrings[0].Length <= twoStrings[1].Length)
            {
                smallerElemet = twoStrings[0];
                biggerElement = twoStrings[1];
            }
            else
            {
                smallerElemet = twoStrings[1];
                biggerElement = twoStrings[0];
            }

            for(int i = 0; i < biggerElement.Length; i++)
            {
                if(i >= smallerElemet.Length)
                {
                    sum += (int)biggerElement[i];
                }
                else
                {
                    sum += ((int)smallerElemet[i] * (int)biggerElement[i]);
                }            
            }
            Console.WriteLine(sum);
        }
    }
}
