namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using Interfaces;
    using Skills;
    using System.Collections.Generic;

    public class BeastMasterHunter : Classes.Hunter
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Multi-Shot", 1, 1),
            new OffensiveSkill("Concussive Shot",  1, 1)
        };

        public BeastMasterHunter() : this(specialisationSkills)
        {
        }

        public BeastMasterHunter(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}