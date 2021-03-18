using _1.Logger.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Appenders
{
    public interface IAppender
    {
        public void Append(string date, ReportLevels reportLevel, string message);

        ReportLevels ReportLevel { get; set; }
    }
}
