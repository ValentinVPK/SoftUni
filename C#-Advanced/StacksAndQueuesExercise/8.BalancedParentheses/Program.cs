using System;
using System.Collections.Generic;

namespace _8.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> openingParentheses = new Stack<char>();

            bool isCorrect = true;
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    openingParentheses.Push(input[i]);
                }

                if (openingParentheses.Count > 0)
                {
                    if (input[i] == ')')
                    {
                        if (openingParentheses.Peek() == '(') openingParentheses.Pop();
                        else
                        {
                            isCorrect = false;
                            break;
                        }
                    }
                    if (input[i] == '}')
                    {
                        if (openingParentheses.Peek() == '{') openingParentheses.Pop();
                        else
                        {
                            isCorrect = false;
                            break;
                        }
                    }
                    if (input[i] == ']')
                    {
                        if (openingParentheses.Peek() == '[') openingParentheses.Pop();
                        else
                        {
                            isCorrect = false;
                            break;
                        }
                    }
                }
                else
                {
                    isCorrect = false;
                    break;
                }
            }


            if (isCorrect) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
