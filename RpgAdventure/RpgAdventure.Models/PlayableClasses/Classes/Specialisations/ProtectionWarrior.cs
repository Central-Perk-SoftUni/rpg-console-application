namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using Classes;
    using Interfaces;
    using Skills;
    using System.Collections.Generic;

    public class ProtectionWarrior : Warrior
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Devastate", 1,  1),
            new DefensiveSkill("Shield Block", 1,  1)
        };

        public ProtectionWarrior() : this(specialisationSkills)
        {
        }

        public ProtectionWarrior(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}