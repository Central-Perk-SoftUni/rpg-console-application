using System;
using RpgAdventure.Core.Factories;
using RpgAdventure.Services.Interfaces;
using RpgAdventure.Utilities.Interfaces;

namespace RpgAdventure.Core
{
    using RpgAdventure.Core.Commands;
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Services;

    public class CommandParser : ICommandParser
    {
        private readonly IMenuService menuService;

        public CommandParser(IMenuService menuService)
        {
            this.menuService = menuService;
        }

        public void ParseCommand(string commandName)
        {
            IFactory<ICommand> commandFactory = new CommandFactory();
            ICommand command = commandFactory.Create(commandName);
            command.Execute();
        }
    }
}
