using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models.Skills
{
    using System;
    using Utilities;

    public abstract class Skill : ICastable
    {
        private const string SkillNameCannotBeNullOrWhitespace = "Skill name can not be null or whitespace!";

        private string name;
        protected int manaCost;
        protected int levelRequired;

        protected Skill(string name, int manaCost, int levelRequired)
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
                    throw new ArgumentNullException(SkillNameCannotBeNullOrWhitespace);
                }
                this.name = value;
            }
        }

        public abstract void TryCast<T>(T target);
    }
}
