namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    using System.Collections.Generic;
    using Interfaces;
    using Skills;

    public class FireMage : Classes.Mage
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Fireball", 1, 1, 1),
            new OffensiveSkill("Fire Blast", 1, 1, 1)
        };


        public FireMage() : this(specialisationSkills)
        {

        }

        public FireMage(ICollection<ICastable> specialisationSkills)
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}