using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Exceptions;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Interfaces.Items;

namespace RpgAdventure.Models.Items
{
    public class Weapon : IWeapon
    {
        private int attackDamage;

        public Weapon(IStatsInfo stats, ItemRarity rarity, WeaponType type, int attackDamage)
        {
            this.Stats = stats;
            this.Rarity = rarity;
            this.Type = type;
            this.AttackDamage = attackDamage;
        }

        public IStatsInfo Stats { get; set; }
        public ItemRarity Rarity { get; set; }

        public int AttackDamage
        {
            get { return this.attackDamage; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Attack Damage");
                }
                this.attackDamage = value;
            }
        }

        public WeaponType Type { get; set; }
    }
}