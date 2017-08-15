using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Services.Interfaces
{
    using RpgAdventure.Models.Interfaces;

    public interface IGameService
    {
        IPlayer Player { get; }

        IEnemy Enemy { get; }

        void StartGame();
    }
}
