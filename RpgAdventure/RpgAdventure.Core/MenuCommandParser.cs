using RpgAdventure.Core.Interfaces.Factories;

namespace RpgAdventure.Core
{
    using RpgAdventure.Core.Interfaces;

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