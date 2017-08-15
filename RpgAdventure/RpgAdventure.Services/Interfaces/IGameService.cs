namespace RpgAdventure.Services.Interfaces
{
    using RpgAdventure.Models.Interfaces;

    public interface IGameService
    {
        void StartGame();

        void CreateNewGame();
    }
}