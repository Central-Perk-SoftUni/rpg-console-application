using RpgAdventure.Models.Exceptions;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models
{
    public class StatsInfo : IStatsInfo
    {
        private int stamina;
        private int intellect;
        private int agility;
        private int strength;

        public StatsInfo(int stamina, int intellect, int agility, int strength)
        {
            this.Stamina = stamina;
            this.Intellect = intellect;
            this.Agility = agility;
            this.Strength = strength;
        }

        public int Stamina
        {
            get { return this.stamina; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Stamina");
                }
                this.stamina = value;
            }
        }

        public int Intellect
        {
            get { return this.intellect; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Intellect");
                }
                this.intellect = value;
            }
        }

        public int Agility
        {
            get { return this.agility; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Agility");
                }
                this.agility = value;
            }
        }

        public int Strength
        {
            get { return this.strength; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Strength");
                }
                this.strength = value;
            }
        }
    }
}