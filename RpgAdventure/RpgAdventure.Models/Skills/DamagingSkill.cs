using RpgAdventure.Models.Interfaces;
using RpgAdventure.Utilities;
using System;

namespace RpgAdventure.Models.Skills
{
    public class DamagingSkill : Skill
    {
        private int damageDealt;

        public DamagingSkill(int manaCost, int levelRequired, int damageDealt) : base(manaCost, levelRequired)
        {

        }

        public int DamageDealt
        {
            get => this.damageDealt;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Join(Constants.ErrorMessages.NumericValueCannotBeNegative, "Damadge dealt"));
                }
                this.damageDealt = value;
            }
        }

        public override void TryCast<T>(T target)
        {
            if (typeof(T) != typeof(IEnemy))
            {
                throw new ArgumentException(Constants.ErrorMessages.CannotDamageFriendly);
            }
            Cast((IEnemy)target);
        }

        private void Cast(IEnemy target)
        {
            //TODO
        }
    }
}
