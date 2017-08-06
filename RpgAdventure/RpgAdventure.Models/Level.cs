using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models
{
    class Level : ILevelInfo
    {
        public Level() : this(1, 0, 100)
        {
        }

        private Level(int current, int experience, int totalExperienceRequired)
        {
            Current = current;
            Experience = experience;
            TotalExperienceRequired = totalExperienceRequired;
        }

        public int Current { get; private set; }

        public int Experience { get; private set; }

        public int TotalExperienceRequired { get; private set; }

        public int ExperienceToNextLevel => this.TotalExperienceRequired - this.Experience;

        public void AddExperience(int experience)
        {
            int newExperience = this.Experience + experience;
            if (TotalExperienceRequired <= newExperience)
            {
                this.Experience = newExperience;
                Next();
            }
        }

        private void Next()
        {
            if (this.Current < 59 && this.Experience >= this.TotalExperienceRequired)
            {
                this.Experience -= this.TotalExperienceRequired;
                this.TotalExperienceRequired = (int)(this.TotalExperienceRequired * 1.5);
                this.Current++;
            }
            else if (this.Current == 59 && this.Experience >= this.TotalExperienceRequired)
            {
                this.Experience = 0;
                this.TotalExperienceRequired = 0;
                this.Current++;
            }
        }
    }
}
