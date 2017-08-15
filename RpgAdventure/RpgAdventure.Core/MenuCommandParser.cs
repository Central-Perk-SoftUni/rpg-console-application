using System;
using RpgAdventure.Core.Interfaces.Factories;
using RpgAdventure.Services.Interfaces;

namespace RpgAdventure.Core
{
    using RpgAdventure.Core.Commands;
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Services;

    public class MenuCommandParser : IMenuCommandParser
    {
        private readonly IMenuCommandFactory menuCommandFactory;

        public MenuCommandParser(IMenuCommandFactory menuCommandFactory)
        {
            this.menuCommandFactory = menuCommandFactory;
        }

        public void ParseCommand(string commandName)
        {
            ICommand command = menuCommandFactory.GetCommand(commandName);
            command.Execute();
        }
    }
}
