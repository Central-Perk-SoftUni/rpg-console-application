using RpgAdventure.Models.Interfaces;
using RpgAdventure.Utilities;
using System;

namespace RpgAdventure.Models.Skills
{
    public class OffensiveSkill : Skill
    {
        public const string CannotDamageFriendlyException = "Damaging abilities cannot be cast on friendly targets";

        private int damageDealt;

        public OffensiveSkill(string name, int manaCost, int levelRequired, int damageDealt) : base(name, manaCost, levelRequired)
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
                    throw new ArgumentException(string.Join(Constants.ErrorMessages.NumericValueCannotBeNegativeException, "Damage dealt"));
                }
                this.damageDealt = value;
            }
        }

        public override void TryCast<T>(T target)
        {
            if (typeof(T) != typeof(IEnemy))
            {
                throw new ArgumentException(CannotDamageFriendlyException);
            }
            this.Cast((IEnemy)target);
        }

        private void Cast(IEnemy target)
        {
            //TODO
        }
    }
}
