using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Core.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
