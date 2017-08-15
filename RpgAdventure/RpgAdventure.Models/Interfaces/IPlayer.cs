namespace RpgAdventure.Models.Interfaces
{
    public interface IPlayer
    {
        IPlayableClass Class { get; set; }
        IRace Race { get; set; }
        string Name { get; set; }
        IInventory Inventory { get; set; }
        IHealthInfo HealthInfo { get; set; }
        IGear EquippedItems { get; set; }
        ILevelInfo LevelInfo { get; set; }
    }
}