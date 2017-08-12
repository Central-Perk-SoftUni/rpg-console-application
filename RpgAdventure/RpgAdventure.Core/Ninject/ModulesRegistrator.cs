using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Factory;
using RpgAdventure.Core.Commands;
using RpgAdventure.Core.Interfaces;
using RpgAdventure.Core.Interfaces.Factories;
using RpgAdventure.Core.Ninject.FactoryInstanceProviders;
using RpgAdventure.Models.Interfaces.Factories;
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
            this.kernel.Bind<IEngine>().To<Engine>();
            this.kernel.Bind<ICommandParser>().To<CommandParser>();
            this.kernel.Bind<IWriter>().To<ConsoleWriter>();
            this.kernel.Bind<IReader>().To<ConsoleReader>();
            this.kernel.Bind<IMenuService>().To<MenuService>();

            this.kernel.Bind<ICommandFactory>().ToFactory(() => new CommandFactoryInstanceProvider(this.kernel));
            this.kernel.Bind<IPlayableClassFactory>()
                .ToFactory(() => new PlayableClassFactoryInstanceProvider(this.kernel));
        }
    }
}
