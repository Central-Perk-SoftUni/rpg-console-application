namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using System.Collections.Generic;
    using Interfaces;
    using Skills;

    public class ArmsWarrior : Warrior
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Mortal Strike", 1,  1),
            new OffensiveSkill("Colossus Smash", 1,  1)
        };

        public ArmsWarrior() : this(specialisationSkills)
        {

        }

        public ArmsWarrior(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}