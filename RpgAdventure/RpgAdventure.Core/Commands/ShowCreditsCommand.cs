using RpgAdventure.Services.Interfaces;
using RpgAdventure.Services.Interfaces.OutputServices;

namespace RpgAdventure.Core.Commands
{
    using RpgAdventure.Core.Interfaces;

    public class ShowCreditsCommand : ICommand
    {
        private readonly IMenuOutputService menuOutputService;

        public ShowCreditsCommand(IMenuOutputService menuOutputService)
        {
            this.menuOutputService = menuOutputService;
        }

        public void Execute()
        {
            this.menuOutputService.ShowCredits();
        }
    }
}