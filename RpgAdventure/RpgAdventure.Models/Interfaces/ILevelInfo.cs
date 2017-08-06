namespace RpgAdventure.Models.Interfaces
{
    public interface ILevelInfo
    {
        int CurrentLevel { get; set; }
        int CurrentExperience { get; set; } 
        int TotalExperienceToNextLevel { get; set; }
    }
}
