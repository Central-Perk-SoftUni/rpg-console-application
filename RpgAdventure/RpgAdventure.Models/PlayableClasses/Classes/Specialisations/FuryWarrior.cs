namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using System.Collections.Generic;
    using Interfaces;
    using Skills;

    public class FuryWarrior : Classes.Warrior
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Furious Slash", 1,  1),
            new OffensiveSkill("Rampage", 1,  1)
        };

        public FuryWarrior() : this(specialisationSkills)
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