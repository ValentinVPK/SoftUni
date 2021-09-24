﻿using DependencyInjection.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DependencyInjection.Loggers
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
