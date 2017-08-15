namespace RpgAdventure.Models.Interfaces
{
    public interface IHealthInfo
    {
        int MaxHealth { get; set; }
        int CurrentHealth { get; set; }
    }
}