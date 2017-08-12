using System;
using RpgAdventure.Core.Interfaces.Factories;
using RpgAdventure.Services.Interfaces;

namespace RpgAdventure.Core
{
    using RpgAdventure.Core.Commands;
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Services;

    public class CommandParser : ICommandParser
    {
        private readonly ICommandFactory commandFactory;

        public CommandParser(ICommandFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }

        public void ParseCommand(string commandName)
        {
            ICommand command = commandFactory.GetCommand(commandName);
            command.Execute();
        }
    }
}
