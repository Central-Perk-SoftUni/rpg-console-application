using System;
using System.Collections.Generic;
using RpgAdventure.Core.Interfaces;
using RpgAdventure.Core.Interfaces.GameCore;
using RpgAdventure.Models;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Services.Interfaces;
using RpgAdventure.Services.Interfaces.OutputServices;

namespace RpgAdventure.Core.GameCore
{
    public class GamePlatform  : IGamePlatform
    {
        private IGameService gameService;
        private IGameOutputService gameOutputService;
        private IRaceService raceService;

        public GamePlatform(IGameService gameService,IRaceService raceService, IGameOutputService gameOutputService)
        {
            this.gameService = gameService;
            this.gameOutputService = gameOutputService;
            this.raceService = raceService;

        }

        public void CreateNewGame()
        {
            ICollection<Type> races = this.raceService.GetAllRaces();
            this.gameOutputService.RaceSelectOutput(races);
        }
    }
}
