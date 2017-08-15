using RpgAdventure.Models.Exceptions;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Interfaces.Spells;

namespace RpgAdventure.Models.Skills
{
    public class DefensiveSkill : Skill, IDefensiveSkill
    {
        private int healingDealt;

        public DefensiveSkill(string name, int manaCost, int healingDealt) : base(name, manaCost)
        {
            this.HealingDealt = healingDealt;
        }

        public int HealingDealt
        {
            get { return this.healingDealt; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Healing Dealt");
                }
                this.healingDealt = value;
            }
        }

        public void Cast(IPlayer target)
        {
            //TODO
        }
    }
}