namespace RpgAdventure.Core
{
    using RpgAdventure.Core.Commands;
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Services;

    public class CommandParser : ICommandParser
    {
        private readonly MenuService menuService;

        public CommandParser()
        {
            this.menuService = new MenuService();
        }

        public void ParseCommand(int action)
        {
            switch (action)
            {
                case 1:
                    // NewGameCommand TO DO...
                    break;

                case 2:
                    ICommand showCreditsCommand = new ShowCreditsCommand(this.menuService);
                    showCreditsCommand.Execute();
                    break;

                case 3:
                    ICommand exitCommand = new ExitCommand();
                    exitCommand.Execute();
                    break;
            }
        }
    }
}
