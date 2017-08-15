using RpgAdventure.Models.Exceptions;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Interfaces.Spells;

namespace RpgAdventure.Models.Skills
{
    public class OffensiveSkill : Skill, IOffensiveSKill
    {
        private int damageDealt;

        public OffensiveSkill(string name, int manaCost, int damageDealt) : base(name, manaCost)
        {
            this.DamageDealt = damageDealt;
        }

        public int DamageDealt
        {
            get => this.damageDealt;
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Damage dealt");
                }
                this.damageDealt = value;
            }
        }

        public void Cast(IEnemy target)
        {
            //TODO
        }
    }
}