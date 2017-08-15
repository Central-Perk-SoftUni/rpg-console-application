namespace RpgAdventure.Models.Interfaces
{
    public interface ILevelInfo
    {
        int CurrentLevel { get; }
        int CurrentExperience { get; }
        int TotalExperienceRequiredToNextLevel { get; }
    }
}