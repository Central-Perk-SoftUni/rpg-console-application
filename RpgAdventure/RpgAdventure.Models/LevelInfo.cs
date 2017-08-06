using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models
{
    class LevelInfo : ILevelInfo
    {
        private const int DefaultStartingLevel = 1;
        private const int DefaultStartingExperience = 0;
        private const int DefaultStartingExperienceToNextLevel = 100;

        private const int MaxLevel = 60;
        private const double ExperienceMultiplier = 1.5;

        public LevelInfo() : this(DefaultStartingLevel, DefaultStartingExperience, DefaultStartingExperienceToNextLevel)
        {

        }

        private LevelInfo(int currentLevel, int currentExperience, int totalExperienceRequiredToNextLevel)
        {
            this.CurrentLevel = currentLevel;
            this.CurrentExperience = currentExperience;
            this.TotalExperienceRequiredToNextLevel = totalExperienceRequiredToNextLevel;
        }

        public int CurrentLevel { get; private set; }

        public int CurrentExperience { get; private set; }

        public int TotalExperienceRequiredToNextLevel { get; private set; }

        public int ExperienceLeftToNextLevel => this.TotalExperienceRequiredToNextLevel - this.CurrentExperience;

        public void AddExperience(int experience)
        {
            int newExperience = this.CurrentExperience + experience;
            this.CurrentExperience = newExperience;
            if (TotalExperienceRequiredToNextLevel <= newExperience)
            {
                this.LevelUp();
            }
        }

        private void LevelUp()
        {
            this.CurrentExperience -= this.TotalExperienceRequiredToNextLevel;
            if (this.CurrentLevel < MaxLevel - 1 && this.CurrentExperience >= this.TotalExperienceRequiredToNextLevel)
            {
                this.TotalExperienceRequiredToNextLevel = (int)(this.TotalExperienceRequiredToNextLevel * ExperienceMultiplier);
            }
            else if (this.CurrentLevel == MaxLevel - 1 && this.CurrentExperience >= this.TotalExperienceRequiredToNextLevel)
            {
                this.TotalExperienceRequiredToNextLevel = int.MaxValue;
            }
            this.CurrentLevel++;
        }
    }
}
