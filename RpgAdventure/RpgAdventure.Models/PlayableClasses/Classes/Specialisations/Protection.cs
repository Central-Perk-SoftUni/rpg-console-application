namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using System.Collections.Generic;
    using Classes;
    using Interfaces;
    using Skills;

    public class Protection : Warrior
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Devastate", 1, 1, 1),
            new DefensiveSkill("Shield Block", 1, 1, 1)
        };

        public Protection() : this(specialisationSkills)
        {

        }

        public Protection(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}