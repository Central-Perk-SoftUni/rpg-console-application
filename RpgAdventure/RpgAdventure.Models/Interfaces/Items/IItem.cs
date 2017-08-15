using RpgAdventure.Models.Enums;

namespace RpgAdventure.Models.Interfaces.Items
{
    public interface IItem
    {
        IStatsInfo Stats { get; set; }
        ItemRarity Rarity { get; set; }
    }
}