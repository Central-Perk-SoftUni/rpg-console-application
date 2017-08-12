using System;
using System.Linq;
using System.Reflection;
using Ninject;
using RpgAdventure.Core.Interfaces;
using RpgAdventure.Core.Ninject;
using RpgAdventure.Models;
using RpgAdventure.Services;
using RpgAdventure.Services.Interfaces;
using RpgAdventure.Services.Interfaces.IO;
using RpgAdventure.Services.IO;

namespace RpgAdventure.Core
{
    public class StartUp
    {
        public static void Main()
        {

            IKernel kernel = new StandardKernel();
            ModulesRegistrator modulesRegistrator = new ModulesRegistrator(kernel);
            modulesRegistrator.RegisterModules();
            IEngine engine = kernel.Get<IEngine>();
            engine.Run();

        }
    }
}
