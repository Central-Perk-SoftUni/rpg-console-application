using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Models.Interfaces
{
    public interface IEnemy
    {
        string Name { get; }
        IStatsInfo Stats { get; }
        int Level { get; }
    }
}
