
using MicrosoftDependencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDependencyInjection.Loggers
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
