using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models.Skills
{
    public abstract class Skill : ICastable
    {
        public Skill(int manaCost, int levelRequired)
        {
            this.manaCost = manaCost;
            this.levelRequired = levelRequired;
        }

        protected int manaCost;
        protected int levelRequired;

        public abstract void TryCast<T>(T target);
    }
}
