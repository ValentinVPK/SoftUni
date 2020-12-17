using System;
using System.Linq;

namespace SedmaZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int firstSign = input.IndexOf('>');
            var inputList = input.ToList();


            int strength = 0;
            for(int i = firstSign; i < inputList.Count - 1; i++)
            {
                char current = inputList[i];

                if(current == '>')
                {
                    strength += int.Parse(Convert.ToString(inputList[i + 1]));
                    int j = i + 1;
                    while(strength != 0 && j < inputList.Count)
                    {
                        if(inputList[j] == '>')
                        {
                            break;
                        }
                        else
                        {
                            inputList.RemoveAt(j);
                            strength--;
                        }
                    }
                }
            }
            
            Console.WriteLine(string.Join("", inputList));
        }
    }
}
