using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Factory.Factory;
using Ninject.Parameters;
using RpgAdventure.Core.Interfaces;

namespace RpgAdventure.Core.Ninject
{
    public class CommandFactoryInstanceProvider : IInstanceProvider
    {
        private const string CommandsNamespace = "RpgAdventure.Core.Commands";

        private readonly IKernel kernel;

        public CommandFactoryInstanceProvider(IKernel kernel)
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
