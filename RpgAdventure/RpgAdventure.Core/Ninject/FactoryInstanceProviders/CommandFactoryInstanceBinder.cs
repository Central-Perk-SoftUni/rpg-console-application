using System;
using System.Reflection;
using Ninject;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Factory.Factory;

namespace RpgAdventure.Core.Ninject
{
    public class MenuCommandFactoryInstanceProvider : IInstanceProvider
    {
        private const string CommandsNamespace = "RpgAdventure.Core.Commands";

        private readonly IKernel kernel;

        public MenuCommandFactoryInstanceProvider(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public object GetInstance(IInstanceResolver instanceResolver, MethodInfo methodInfo, object[] arguments)
        {
            string command = $"{CommandsNamespace}.{arguments[0]}Command";
            Type commandType = Type.GetType(command);
            return this.kernel.Get(commandType);
        }
    }
}