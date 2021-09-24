
using Microsoft.Extensions.DependencyInjection;
using MicrosoftDependencyInjection.Contracts;
using MicrosoftDependencyInjection.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftDependencyInjection
{
    class ServiceConfigurator
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<ILogger, ConsoleLogger>();

            serviceCollection.AddTransient<Engine, Engine>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
