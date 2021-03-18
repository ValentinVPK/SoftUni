using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Loggers
{
    public interface ILogFile
    {
        int Size { get; }
        void Write(string content);
    }
}
