using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Interfaces.Items;

namespace RpgAdventure.Models.Items
{
    public class Weapon : IWeapon
    {
        public Weapon(IStatsInfo stats, ItemRarity rarity, WeaponType type, int attackDamage)
        {
            this.Stats = stats;
            this.Rarity = rarity;
            this.Type = type;
            this.AttackDamage = attackDamage;
        }

        public IStatsInfo Stats { get; set; }
        public ItemRarity Rarity { get; set; }
        public int AttackDamage { get; set; }
        public WeaponType Type { get; set; }
    }
}
