using _1.Logger.Appenders;
using _1.Logger.Enums;
using _1.Logger.Layouts;
using _1.Logger.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Core.Factories
{
    public class AppenderFactory : IAppendFactory
    {
        public IAppender CreateAppender(string type, ILayout layout, ReportLevels reportLevel)
        {
            IAppender appender;

            switch (type)
            {
                case nameof(ConsoleAppender):
                    appender = new ConsoleAppender(layout)
                    {
                        ReportLevel = reportLevel
                    };
                    break;
                case nameof(FileAppender):
                    appender = new FileAppender(layout, new LogFile())
                    {
                        ReportLevel = reportLevel
                    };
                    break;
                default:
                    throw new ArgumentException($"{type} is invalid appender type");
            }

            return appender;
        }
    }
}
