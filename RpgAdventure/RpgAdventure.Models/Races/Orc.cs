using RpgAdventure.Models.Interfaces;
using System;
using System.Collections.Generic;
using RpgAdventure.Models.PlayableClasses.Classes;
using RpgAdventure.Models.Skills;

namespace RpgAdventure.Models.Races
{
    public class Orc : Race
    {
        private static readonly ICollection<Type> PlayableCLasses = new List<Type>()
        {
            typeof(Hunter),typeof(Warrior)
        };

        private static readonly ICollection<ICastable> Spells = new List<ICastable>()
        {
            new DefensiveSkill("Berserking", 0, 0)
        };

        public Orc() : this(Spells, PlayableCLasses)
        {
        }

        public Orc(ICollection<ICastable> skills, ICollection<Type> playableClasses) : base(skills, playableClasses)
        {
        }
    }
}