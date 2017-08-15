namespace RpgAdventure.Services
{
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Models.Interfaces;
    using RpgAdventure.Services.Interfaces;
    using RpgAdventure.Services.Interfaces.IO;

    public class GameService : IGameService
    {
        private IReader consoleReader;
        private IWriter consoleWriter;
        private IConsoleManipulator consoleManipulator;
        private IGame game;
        private IPlayer player;
        private IEnemy enemy;

        public GameService(IWriter writer, IReader reader, IConsoleManipulator manipulator, IGame game)
        {
            this.game = game;
            this.consoleWriter = writer;
            this.consoleReader = reader;
            this.consoleManipulator = manipulator;
        }

        public IPlayer Player => this.player;

        public IEnemy Enemy => this.enemy;

        public void StartGame()
        {
            this.game.CreatePlayer(this.Player);
            // TO DO...
            while (this.Player.HealthInfo.CurrentHealth > 0)
            {
                this.game.SpawnEnemy(this.Enemy);
                this.game.Battle(this.Player, this.Enemy);
                //...
            }

            this.game.EndGame();
        }
    }
}
