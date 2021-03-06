﻿using RpgAdventure.Models.Exceptions;
using RpgAdventure.Models.Interfaces;

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
                    throw new StringNullOrEmptyException("Name");
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
                    throw new NegativeNumberException("Mana cost");
                }
                this.manaCost = value;
            }
        }
    }
}