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
    public class Armor : IArmor
    {
        public Armor(IStatsInfo stats, ItemRarity rarity, ArmorMaterial material, ArmorType type)
        {
            this.Stats = stats;
            this.Rarity = rarity;
            this.Material = material;
            this.Type = type;
        }

        public IStatsInfo Stats { get; set; }
        public ItemRarity Rarity { get; set; }
        public ArmorMaterial Material { get; set; }
        public ArmorType Type { get; set; }
    }
}
