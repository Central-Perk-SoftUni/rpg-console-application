using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Core.Commands
{
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Services.Interfaces;

    public class NewGameCommand : ICommand
    {
        private readonly IGameService gameService;

        public NewGameCommand(IGameService gameService)
        {
            this.gameService = gameService;
        }

        public void Execute()
        {
            this.gameService.StartGame();
        }
    }
}
