using RpgAdventure.Models.Exceptions;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models
{
    public class HealthInfo : IHealthInfo
    {
        private int currentHealth;
        private int maxHealth;

        public HealthInfo(int maxHealth, int currentHealth)
        {
            this.MaxHealth = maxHealth;
            this.CurrentHealth = currentHealth;
        }

        public int MaxHealth
        {
            get { return this.maxHealth; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Max Health");
                }
                this.maxHealth = value;
            }
        }

        public int CurrentHealth
        {
            get { return this.currentHealth; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Current Health");
                }
                this.currentHealth = value;
            }
        }
    }
}