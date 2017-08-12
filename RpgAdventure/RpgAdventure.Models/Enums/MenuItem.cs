namespace RpgAdventure.Models.Enums
{
    using System.ComponentModel;

    public enum MenuItem
    {
        [Description("New Game")]NewGame,
        [Description("Credits")]ShowCredits,
        [Description("Exit Game")]Exit
    }
}
