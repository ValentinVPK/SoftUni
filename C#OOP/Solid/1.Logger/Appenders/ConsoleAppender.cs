using _1.Logger.Enums;
using _1.Logger.Layouts;
using System;

namespace _1.Logger.Appenders
{
    
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {

        }

        public override void Append(string date, ReportLevels reportLevel, string message)
        {
            if(this.CanAppend(reportLevel))
            {
                string content = string.Format(this.layout.Template, date, reportLevel, message);

                Console.WriteLine(content);

                this.MessagesCount++;
            }
        }
    }
}
