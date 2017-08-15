using System;
using System.Collections.Generic;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Utilities;

namespace RpgAdventure.Services.Interfaces.OutputServices
{
    public interface IGameOutputService
    {
        void RaceSelectOutput(ICollection<Type> races,PrintCoordinates coordinates);

        void RaceSelectOutput(ICollection<Type> races);
    }
}
