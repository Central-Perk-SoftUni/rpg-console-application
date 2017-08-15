using RpgAdventure.Core.Interfaces.GameCore;

namespace RpgAdventure.Core.Commands
{
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Services.Interfaces;

    public class NewGameCommand : ICommand
    {
        private readonly IGamePlatform gamePlatform;

        public NewGameCommand(IGamePlatform gamePlatform)
        {
            this.gamePlatform = gamePlatform;
        }

        public void Execute()
        {
            this.gamePlatform.CreateNewGame();
        }
    }
}