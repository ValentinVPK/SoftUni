using _1.Logger.Appenders;
using _1.Logger.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Loggers
{
    public class Loogger : ILogger
    {
        private readonly IAppender[] appenders;

        public Loogger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Critical(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevels.Critical, message);
        }

        public void Error(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevels.Error, message);
        }

        public void Fatal(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevels.Fatal, message);
        }

        public void Info(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevels.Info, message);
        }
        public void Warning(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevels.Warning, message);
        }

        private void AppendToAppenders(string date, ReportLevels reportLevel, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(date, reportLevel, message);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
