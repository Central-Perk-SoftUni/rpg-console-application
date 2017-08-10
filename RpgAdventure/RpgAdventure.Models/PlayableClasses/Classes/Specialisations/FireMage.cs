using System.Collections.Generic;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Skills;

namespace RpgAdventure.Models.PlayableClasses.Classes.MageSpecialisations
{
    public class FireMage : Mage
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Pyroblast", 1, 1),
            new OffensiveSkill("Combustion",  1, 1)
        };


        public FireMage() : this(specialisationSkills)
        {

        }

        public FireMage(ICollection<ICastable> specialisationSkills) :base()
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}