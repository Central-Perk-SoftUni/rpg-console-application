namespace RpgAdventure.Models.Interfaces
{
    public interface ILevelInfo
    {
        int Current { get; }
        int Experience { get; }
        int TotalExperienceRequired { get; }
    }
}
