using _1.Logger.Enums;
using _1.Logger.Layouts;

namespace _1.Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        protected readonly ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }

        protected int MessagesCount { get; set; }
        public ReportLevels ReportLevel { get; set; }

        public abstract void Append(string date, ReportLevels reportLevel, string message);

        protected bool CanAppend(ReportLevels reportLevel)
        {
            return reportLevel >= this.ReportLevel;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.MessagesCount}";
        }
    }
}
