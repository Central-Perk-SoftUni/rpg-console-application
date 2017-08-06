using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models
{
    class Enemy : IEnemy
    {
        public Enemy(string name, IStatsInfo stats, int level)
        {
            this.Name = name;
            this.Stats = stats;
            this.Level = level;
        }

        public string Name { get; private set; }

        public IStatsInfo Stats { get; private set; }

        public int Level { get; private set; }
    }
}
