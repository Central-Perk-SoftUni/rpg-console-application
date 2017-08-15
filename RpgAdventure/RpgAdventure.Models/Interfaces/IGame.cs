namespace RpgAdventure.Core.Interfaces
{
    using RpgAdventure.Models.Interfaces;

    public interface IGame
    {
        void CreatePlayer(IPlayer player);

        void SpawnEnemy(IEnemy enemy);

        void Battle(IPlayer player, IEnemy enemy);

        void EndGame();
    }
}
