using Ninject;
using Ninject.Extensions.Factory;
using RpgAdventure.Core.GameCore;
using RpgAdventure.Core.Interfaces;
using RpgAdventure.Core.Interfaces.Factories;
using RpgAdventure.Core.Interfaces.GameCore;
using RpgAdventure.Core.Ninject.FactoryInstanceProviders;
using RpgAdventure.Models;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Interfaces.Factories;
using RpgAdventure.Services;
using RpgAdventure.Services.Interfaces;
using RpgAdventure.Services.Interfaces.IO;
using RpgAdventure.Services.Interfaces.OutputServices;
using RpgAdventure.Services.IO;
using RpgAdventure.Services.OutputServices;

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
            this.kernel.Bind<IMenuCommandParser>().To<MenuCommandParser>();
            this.kernel.Bind<IConsoleManipulator>().To<ConsoleManipulator>();
            this.kernel.Bind<IWriter>().To<ConsoleWriter>();
            this.kernel.Bind<IReader>().To<ConsoleReader>();
            this.kernel.Bind<IMenuOutputService>().To<MenuOutputService>();
            this.kernel.Bind<IGameService>().To<GameService>();
            this.kernel.Bind<IGameOutputService>().To<GameOutputService>();
            this.kernel.Bind<IRaceService>().To<RaceService>();
            this.kernel.Bind<IMenu>().To<Menu>();
            this.kernel.Bind<IMenuNavigator>().To<MenuNavigator>();
            this.kernel.Bind<IGamePlatform>().To<GamePlatform>();

            this.kernel.Bind<IMenuCommandFactory>().ToFactory(() => new MenuCommandFactoryInstanceProvider(this.kernel));
            this.kernel.Bind<IPlayableClassFactory>()
                .ToFactory(() => new PlayableClassFactoryInstanceProvider(this.kernel));
        }
    }
}