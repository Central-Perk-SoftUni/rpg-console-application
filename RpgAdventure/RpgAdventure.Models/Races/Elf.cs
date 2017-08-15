using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.PlayableClasses.Classes;
using RpgAdventure.Models.Skills;
using System;
using System.Collections.Generic;

namespace RpgAdventure.Models.Races
{
    public class Elf : Race
    {
        private static readonly ICollection<Type> PlayableCLasses = new List<Type>()
        {
            typeof(Mage),typeof(Hunter)
        };

        private static readonly ICollection<ICastable> Spells = new List<ICastable>()
        {
            new DefensiveSkill("Shadowmeld", 0, 0)
        };

        public Elf() : this(Spells, PlayableCLasses)
        {
        }

        public Elf(ICollection<ICastable> skills, ICollection<Type> playableClasses) : base(skills, playableClasses)
        {
        }
    }
}