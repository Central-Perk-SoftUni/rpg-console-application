using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models.Races
{
    public class Human: Race
    {
        public Human(ICollection<ICastable> skills, ICollection<Type> playableClasses) : base(skills, playableClasses)
        {
        }
    }
}
