﻿namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using System.Collections.Generic;
    using Interfaces;
    using Skills;

    public class ArcaneMage : Classes.Mage

    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
    {
        new OffensiveSkill("Arcane blast", 1, 1, 1),
        new OffensiveSkill("Arcane Barrage", 1, 1, 1)
    };

        public ArcaneMage() : this(specialisationSkills)
        {

        }

        public ArcaneMage(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}