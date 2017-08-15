namespace RpgAdventure.Models.Interfaces
{
    using RpgAdventure.Models.Enums;
    using System.Collections.Generic;

    public interface IMenu
    {
        int CurrentCursorPosition { get; set; }

        ICollection<MenuItem> MenuItems { get; set; }
    }
}