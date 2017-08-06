﻿using RpgAdventure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Models.Skills
{
    public class HealingSkill : Skill
    {
        private int healingDealt;

        public HealingSkill(int manaCost, int levelRequired, int healingDelt) : base(manaCost, levelRequired)
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
                    throw new ArgumentException(string.Join(Constants.ErrorMessages.NumericValueCannotBeNegative, "Healing Dealt"));
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
