namespace RpgAdventure.Core.Interfaces
{
    using RpgAdventure.Models.Interfaces;

    public interface IGame
    {
        IPlayer Player { get; }

        IEnemy Enemy { get; }

        void CreatePlayer();

        void SpawnEnemy();

        void Battle(IPlayer player, IEnemy enemy);
    }
}
