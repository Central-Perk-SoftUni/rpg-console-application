namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using Interfaces;
    using Skills;
    using System.Collections.Generic;

    public class FuryWarrior : Classes.Warrior
    {
        private static readonly ICollection<ICastable> SpecialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Furious Slash", 1,  1),
            new OffensiveSkill("Rampage", 1,  1)
        };

        public FuryWarrior() : this(SpecialisationSkills)
        {
        }

        public FuryWarrior(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}