using RpgAdventure.Models.Exceptions;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models
{
    internal class LevelInfo : ILevelInfo
    {
        private const int DefaultStartingLevel = 1;
        private const int DefaultStartingExperience = 0;
        private const int DefaultStartingExperienceToNextLevel = 100;

        private const int MaxLevel = 60;
        private const double ExperienceMultiplier = 1.5;

        private int currentLevel;
        private int currentExperience;
        private int totalExperienceRequiredToNextLevel;

        public LevelInfo() : this(DefaultStartingLevel, DefaultStartingExperience, DefaultStartingExperienceToNextLevel)
        {
        }

        private LevelInfo(int currentLevel, int currentExperience, int totalExperienceRequiredToNextLevel)
        {
            this.CurrentLevel = currentLevel;
            this.CurrentExperience = currentExperience;
            this.TotalExperienceRequiredToNextLevel = totalExperienceRequiredToNextLevel;
        }

        public int CurrentLevel
        {
            get { return this.currentLevel; }
            private set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Current Level");
                }
                this.currentLevel = value;
            }
        }

        public int CurrentExperience
        {
            get { return this.currentExperience; }
            private set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Current Experience");
                }
                this.currentExperience = value;
            }
        }

        public int TotalExperienceRequiredToNextLevel
        {
            get { return this.totalExperienceRequiredToNextLevel; }
            private set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Total Experience");
                }
                this.totalExperienceRequiredToNextLevel = value;
            }
        }

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