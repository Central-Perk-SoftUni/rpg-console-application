using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Utilities;

namespace RpgAdventure.Models.Skills
{
    public abstract class Skill : ICastable
    {
        private string name;
        private int manaCost;

        public Skill(string name, int manaCost)
        {
            this.Name = name;
            this.ManaCost = manaCost;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.StringValueCannotBeNullOrEmptyException,"Name"));
                }
                this.name = value;
            }
        }

        public int ManaCost
        {
            get { return this.manaCost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(Constants.ErrorMessages.NumericValueCannotBeNegativeException,"Mana cost"));
                }
                this.manaCost = value;
            }
        }
    }
}
