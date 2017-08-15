using Ninject;
using RpgAdventure.Core.Interfaces;
using RpgAdventure.Core.Ninject;

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