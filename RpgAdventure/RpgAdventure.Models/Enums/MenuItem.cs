namespace RpgAdventure.Models.Enums
{
    using System.ComponentModel;

    public enum MenuItem
    {
        [Description("New Game")]NewGame,
        [Description("Credits")]Credits,
        [Description("Exit Game")]Exit
    }
}
