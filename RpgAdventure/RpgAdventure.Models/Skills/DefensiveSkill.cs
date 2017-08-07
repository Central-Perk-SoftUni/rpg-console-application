using RpgAdventure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Models.Skills
{
    public class DefensiveSkill : Skill
    {
        private int healingDealt;

        public DefensiveSkill(string name, int manaCost, int levelRequired, int healingDealt) : base(name, manaCost, levelRequired)
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

        public override void TryCast<T>(T target)
        {
            //TODO Add Hero interface and model
            //if (typeof(T) != typeof()
            {

            }

        }
    }
}
