namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using System.Collections.Generic;
    using Classes;
    using Interfaces;
    using Skills;

    public class Survival : Hunter
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Raptor Strike", 1,  1),
            new OffensiveSkill("Harpoon", 1,  1)
        };

        public Survival() : this(specialisationSkills)
        {

        }

        public Survival(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}