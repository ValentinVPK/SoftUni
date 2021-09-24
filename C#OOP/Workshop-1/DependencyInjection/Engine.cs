using DependencyInjection.Contracts;
using DependencyInjection.DI.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class Engine
    {
        private ILogger logger;
        private IReader reader;

        [Inject]
        public Engine(ILogger logger, IReader reader)
        {
            this.logger = logger;
            this.reader = reader;
        }

        public void Start()
        {
            logger.Log("Game Started");
        }

        public void End()
        {
            logger.Log("Game Ended");
        }
    }
}
