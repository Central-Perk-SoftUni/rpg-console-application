using RpgAdventure.Models.Enums;

namespace RpgAdventure.Models.Interfaces
{
    public interface IItem
    {
        IStatsInfo Stats { get; set; }
        ItemRarity Rarity { get; set; }
    }
}