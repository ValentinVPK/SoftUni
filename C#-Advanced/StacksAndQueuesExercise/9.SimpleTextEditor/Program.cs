using System;
using System.Collections.Generic;
using System.Text;

namespace _9.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            Stack<string> commands = new Stack<string> ();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        StringBuilder currStringToAdd = new StringBuilder();
                        currStringToAdd.Append(command);
                        for(int j = 1; j < input.Length; j++)
                        {
                            text.Append(input[j]);
                            currStringToAdd.Append(input[j]);
                        }
                        commands.Push(currStringToAdd.ToString());
                        break;
                    case 2:
                        StringBuilder currStringToRemove = new StringBuilder();
                        currStringToRemove.Append(command);
                        int length = int.Parse(input[1]);
                        for(int t = text.Length - length; t < text.Length; t++)
                        {
                            currStringToRemove.Append(text[t]);
                        }
                        text.Remove(text.Length - length, length);
                        commands.Push(currStringToRemove.ToString());
                        break;
                    case 3:
                        int index = int.Parse(input[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case 4:
                        string currCommand = commands.Pop();
                        if(currCommand[0] == '1')
                        {
                            text.Remove((text.Length - currCommand.Substring(1).Length), currCommand.Substring(1).Length);
                        }
                        else if(currCommand[0] == '2')
                        {
                            text.Append(currCommand.Substring(1));
                        }
                        break;
                }
            }     
        }
    }
}
