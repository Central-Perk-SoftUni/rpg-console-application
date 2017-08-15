namespace RpgAdventure.Core.Interfaces
{
    using RpgAdventure.Models.Interfaces;

    public interface IGame
    {
        IPlayer Player { get; set; }

        int Score { get; set; }
    }
}