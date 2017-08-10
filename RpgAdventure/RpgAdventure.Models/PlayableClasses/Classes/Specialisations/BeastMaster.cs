namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using System.Collections.Generic;
    using Interfaces;
    using Skills;

    public class BeastMaster : Classes.Hunter
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Multi-Shot", 1, 1, 1),
            new OffensiveSkill("Concussive Shot", 1, 1, 1)
        };

        public BeastMaster() : this(specialisationSkills)
        {

        }

        public BeastMaster(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}