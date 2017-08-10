using System;
using System.Linq;
using System.Reflection;
using RpgAdventure.Core.Interfaces;
using RpgAdventure.Models;
using RpgAdventure.Services;
using RpgAdventure.Services.Interfaces;
using RpgAdventure.Services.Interfaces.IO;
using RpgAdventure.Services.IO;

namespace RpgAdventure.Core
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleWriter();
            IMenuService menuService = new MenuService(writer);
            ICommandParser commandParser = new CommandParser(menuService);
            IEngine engine = new Engine(commandParser, menuService);
            engine.Run();

        }
    }
}
