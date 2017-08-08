using RpgAdventure.Core.Interfaces;

namespace RpgAdventure.Core
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
