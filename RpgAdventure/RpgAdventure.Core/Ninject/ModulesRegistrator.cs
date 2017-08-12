using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using RpgAdventure.Core.Interfaces;
using RpgAdventure.Services;
using RpgAdventure.Services.Interfaces;
using RpgAdventure.Services.Interfaces.IO;
using RpgAdventure.Services.IO;

namespace RpgAdventure.Core.Ninject
{
    public class ModulesRegistrator
    {
        private readonly IKernel kernel;

        public ModulesRegistrator(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public void RegisterModules()
        {
            kernel.Bind<IEngine>().To<Engine>();
            kernel.Bind<ICommandParser>().To<CommandParser>();
            kernel.Bind<IWriter>().To<ConsoleWriter>();
            kernel.Bind<IReader>().To<ConsoleReader>();
            kernel.Bind<IMenuService>().To<MenuService>();
        }
    }
}
