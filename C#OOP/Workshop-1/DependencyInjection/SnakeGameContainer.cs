using DependencyInjection.Contracts;
using DependencyInjection.DI.Containers;
using DependencyInjection.Loggers;
using DependencyInjection.Readers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class SnakeGameContainer : AbstractContainer
    {
        public override void ConfigureServices()
        {
            this.CreateMapping<ILogger, ConsoleLogger>();
            this.CreateMapping<IReader, ConsoleReader>();
        }
    }
}
