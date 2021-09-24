using DependencyInjection.Contracts;
using DependencyInjection.DI;
using DependencyInjection.DI.Containers;
using DependencyInjection.Loggers;
using System;


namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = new SnakeGameContainer();
            container.ConfigureServices();

            Injector injector = new Injector(container);

            Engine engine = injector.Inject<Engine>();
            //Engine engine1 = GameContainer.Inject<Engine>();

            //engine.Start();
            //engine.End();
        }
    }
}
