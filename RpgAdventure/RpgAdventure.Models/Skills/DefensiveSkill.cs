using RpgAdventure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Interfaces.Spells;

namespace RpgAdventure.Models.Skills
{
    public class DefensiveSkill : Skill,IDefensiveSkill
    {
        private int healingDealt;

        public DefensiveSkill(string name, int manaCost, int healingDealt) : base(name,manaCost)
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
                    throw new ArgumentException(string.Join(Constants.ErrorMessages.NumericValueCannotBeNegativeException, "Healing Dealt"));
                }
                this.healingDealt = value;
            }
        }

        public void Cast(IPlayer target)
        {
            throw new NotImplementedException();
        }
    }
}
