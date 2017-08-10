namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using System.Collections.Generic;
    using Classes;
    using Interfaces;
    using Skills;

    public class FrostMage : Mage
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Frostbolt", 1, 1),
            new OffensiveSkill("Frost Nova", 1,  1)
        };

        public FrostMage() : this(specialisationSkills)
        {

        }

        public FrostMage(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}