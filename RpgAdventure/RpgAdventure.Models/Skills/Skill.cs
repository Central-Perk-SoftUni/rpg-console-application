using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models.Skills
{
    using System;
    using Utilities;

    public abstract class Skill : ICastable
    {
        private string name;
        protected int manaCost;
        protected int levelRequired;

        public Skill(string name, int manaCost, int levelRequired)
        {
            this.Name = name;
            this.manaCost = manaCost;
            this.levelRequired = levelRequired;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(Constants.ErrorMessages.SkillNameCannotBeNullOrWhitespace);
                }
                this.name = value;
            }
        }

        public abstract void TryCast<T>(T target);
    }
}
