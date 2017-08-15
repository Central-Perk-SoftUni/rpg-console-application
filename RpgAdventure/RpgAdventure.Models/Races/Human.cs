using RpgAdventure.Models.Interfaces;
using System;
using System.Collections.Generic;
using RpgAdventure.Models.PlayableClasses.Classes;
using RpgAdventure.Models.Skills;

namespace RpgAdventure.Models.Races
{
    public class Human : Race
    {
        private static readonly ICollection<Type> PlayableCLasses = new List<Type>()
        {
            typeof(Mage),typeof(Warrior)
        };

        private static readonly ICollection<ICastable> Spells = new List<ICastable>()
        {
            new DefensiveSkill("Diplomacy", 0, 0)
        };

        public Human() : this(Spells, PlayableCLasses)
        {
        }

        public Human(ICollection<ICastable> skills, ICollection<Type> playableClasses) : base(skills, playableClasses)
        {
        }
    }
}