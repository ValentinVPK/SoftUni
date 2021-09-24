
using MicrosoftDependencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MicrosoftDependencyInjection.Loggers
{
    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using(StreamWriter writer = new StreamWriter("../../../logs.txt", true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
