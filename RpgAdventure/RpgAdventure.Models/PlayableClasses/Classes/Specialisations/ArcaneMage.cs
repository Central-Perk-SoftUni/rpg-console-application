using System.Collections.Generic;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Skills;

namespace RpgAdventure.Models.PlayableClasses.Classes.Specialisations
{
    public class ArcaneMage : Mage
    {
        private static readonly ICollection<ICastable> specialisationSkills = new List<ICastable>()
        {
            new OffensiveSkill("Arcane blast", 1,  1),
            new OffensiveSkill("Arcane Barrage", 1, 1)
        };

        public ArcaneMage() : this(specialisationSkills)
        {
            
        }

        public ArcaneMage(ICollection<ICastable> specialisationSkills) :base()
        {
            foreach (var specialisationSkll in specialisationSkills)
            {
                this.AddSkill(specialisationSkll);
            }
        }
    }
}