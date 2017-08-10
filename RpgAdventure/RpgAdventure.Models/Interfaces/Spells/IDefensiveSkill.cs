using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Models.Interfaces.Spells
{
    public interface IDefensiveSkill : ICastable
    {
        int HealingDealt { get; set; }
        void Cast(IPlayer target);
    }
}
