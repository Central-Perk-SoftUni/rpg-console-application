using RpgAdventure.Models.Exceptions;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models
{
    internal class Enemy : IEnemy
    {
        private string name;
        private int attackDamage;
        private int level;

        public Enemy(string name, IHealthInfo healthInfo, int attackDamage, int level)
        {
            this.Name = name;
            this.HealthInfo = healthInfo;
            this.AttackDamage = attackDamage;
            this.Level = level;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new StringNullOrEmptyException("Name");
                }
                this.name = value;
            }
        }

        public IHealthInfo HealthInfo { get; }

        public int AttackDamage
        {
            get { return this.attackDamage; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Attack damage");
                }
                this.attackDamage = value;
            }
        }

        public int Level
        {
            get { return this.level; }
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Level");
                }
                this.level = value;
            }
        }
    }
}