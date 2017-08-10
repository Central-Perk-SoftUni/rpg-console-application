using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Models.Interfaces.Spells
{
    public interface IOffensiveSKill : ICastable
    {
        int DamageDealt { get; set; }
        void Cast(IEnemy target);
    }
}
