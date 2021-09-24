using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.DI.Containers
{
    public abstract class AbstractContainer : IContainer
    {
        private Dictionary<Type, Type> mappings;

        protected AbstractContainer()
        {
            mappings = new Dictionary<Type, Type>();
        }
        public abstract void ConfigureServices();

        public void CreateMapping<TInterfaceType, TImplementationType>()
        {
            if(!typeof(TInterfaceType).IsAssignableFrom(typeof(TImplementationType)))
            {
                throw new ArgumentException($"{typeof(TImplementationType).Name} is not assignable from {typeof(TInterfaceType).Name}");
            }

            mappings[typeof(TInterfaceType)] = typeof(TImplementationType);
        }

        public Type GetMapping(Type interfaceType)
        {
            return mappings[interfaceType];
        }
    }
}
