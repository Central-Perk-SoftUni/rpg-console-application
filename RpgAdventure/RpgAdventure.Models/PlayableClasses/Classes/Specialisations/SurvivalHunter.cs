﻿namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using Classes;
    using Interfaces;
    using Skills;
    using System.Collections.Generic;

    public class SurvivalHunter : Hunter
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Raptor Strike", 1,  1),
            new OffensiveSkill("Harpoon", 1,  1)
        };

        public SurvivalHunter() : this(specialisationSkills)
        {
        }

        public SurvivalHunter(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}