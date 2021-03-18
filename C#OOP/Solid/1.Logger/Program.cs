using _1.Logger.Appenders;
using _1.Logger.Core;
using _1.Logger.Core.Factories;
using _1.Logger.Core.IO;
using _1.Logger.Enums;
using _1.Logger.Layouts;
using _1.Logger.Loggers;
using System;
using System.Collections.Generic;

namespace _1.Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            IAppendFactory appenderFactory = new AppenderFactory();
            ILayoutFactory layoutFactory = new LayoutFactory();
            IReader reader = new FileReader();

            IEngine engine = new Engine(layoutFactory, appenderFactory, reader);

            engine.Run();
        }
    }
}
