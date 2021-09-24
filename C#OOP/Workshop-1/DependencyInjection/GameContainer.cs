using DependencyInjection.Contracts;
using DependencyInjection.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    //IoC Containers
    class GameContainer
    {
        public void ConfigureServices()
        {
           // CreateMapping<ILogger, ConsoleLogger>();
        }
    }
}
