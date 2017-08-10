namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using System.Collections.Generic;
    using Interfaces;
    using Skills;

    public class Marksmanship : Classes.Hunter
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Arcane Shot", 1,  1),
            new OffensiveSkill("Aimed Shot", 1,  1)
        };

        public Marksmanship() : this(specialisationSkills)
        {

        }

        public Marksmanship(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}