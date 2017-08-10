namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using System.Collections.Generic;
    using Interfaces;
    using Skills;

    public class Arms : Classes.Warrior
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Mortal Strike", 1, 1, 1),
            new OffensiveSkill("Colossus Smash", 1, 1, 1)
        };

        public Arms() : this(specialisationSkills)
        {

        }

        public Arms(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}