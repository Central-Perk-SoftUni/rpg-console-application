using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models
{
    class Enemy : IEnemy
    {
        public Enemy(string name, IHealthInfo healthInfo,int attackDamage, int level)
        {
            this.Name = name;
            this.HealthInfo = healthInfo;
            this.AttackDamage = attackDamage;
            this.Level = level;
        }

        public string Name { get; private set; }

        public IHealthInfo HealthInfo { get; }

        public int AttackDamage { get; set; }

        public int Level { get; private set; }
    }
}
