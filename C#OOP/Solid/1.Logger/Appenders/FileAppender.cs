using _1.Logger.Enums;
using _1.Logger.Layouts;
using _1.Logger.Loggers;
using System;

namespace _1.Logger.Appenders
{
    public class FileAppender : Appender
    {
        private readonly ILogFile logFile;
        public FileAppender(ILayout layout, ILogFile logFile) 
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string date, ReportLevels reportLevel, string message)
        {
            if (this.CanAppend(reportLevel))
            {
                string content = string.Format(this.layout.Template, date, reportLevel, message) + Environment.NewLine;

                this.logFile.Write(content);
                this.MessagesCount++;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.logFile.Size}";
        }
    }
}
