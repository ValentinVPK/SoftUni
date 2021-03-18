using _1.Logger.Appenders;
using _1.Logger.Enums;
using _1.Logger.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Core.Factories
{
    public interface IAppendFactory
    {
        IAppender CreateAppender(string type, ILayout layout, ReportLevels reportLevel);
    }
}
