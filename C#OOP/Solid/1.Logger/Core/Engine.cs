using _1.Logger.Appenders;
using _1.Logger.Core.Factories;
using _1.Logger.Core.IO;
using _1.Logger.Enums;
using _1.Logger.Layouts;
using _1.Logger.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Logger.Core
{
    public class Engine : IEngine
    {
        private readonly IAppendFactory appenderFactory;
        private readonly ILayoutFactory layoutFactory;
        private readonly IReader reader;

        private ILogger logger;

        public Engine(ILayoutFactory layoutFactory, IAppendFactory appenderFactory, IReader reader)
        {
            this.layoutFactory = layoutFactory;
            this.appenderFactory = appenderFactory;
            this.reader = reader;
        }
        public void Run()
        {
            int n = int.Parse(this.reader.ReadLine());

            IAppender[] appenders = this.ReadAppenders(n);
            this.logger = new Loogger(appenders);

            while (true)
            {
                string line = this.reader.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] parts = line.Split('|');

                ReportLevels reportLevel = Enum.Parse<ReportLevels>(parts[0], true);
                string date = parts[1];
                string message = parts[2];

                this.ProccessCommand(reportLevel, date, message);
            }

            Console.WriteLine(logger);
        }

        private void ProccessCommand(ReportLevels reportLevel, string date, string message)
        {
            switch (reportLevel)
            {
                case ReportLevels.Info:
                    this.logger.Info(date, message);
                    break;
                case ReportLevels.Critical:
                    this.logger.Critical(date, message);
                    break;
                case ReportLevels.Fatal:
                    this.logger.Fatal(date, message);
                    break;
                case ReportLevels.Warning:
                    this.logger.Warning(date, message);
                    break;
                case ReportLevels.Error:
                    this.logger.Error(date, message);
                    break;
            }
        }

        private IAppender[] ReadAppenders(int n)
        {
            IAppender[] appenders = new IAppender[n];
            for (int i = 0; i < n; i++)
            {
                string[] appenderParts = this.reader.ReadLine().Split();

                string appenderType = appenderParts[0];
                string layoutType = appenderParts[1];
                ReportLevels reportLevel = appenderParts.Length == 3
                    ? Enum.Parse<ReportLevels>(appenderParts[2], true)
                    : ReportLevels.Info;

                ILayout layout = this.layoutFactory.CreateLayout(layoutType);

                IAppender appender = this.appenderFactory.CreateAppender(appenderType, layout, reportLevel);

                appenders[i] = appender;
            }

            return appenders;
        }
    }
}
