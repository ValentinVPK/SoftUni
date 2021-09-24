using DependencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Loggers
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
