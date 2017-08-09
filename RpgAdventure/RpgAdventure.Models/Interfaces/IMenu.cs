namespace RpgAdventure.Models.Interfaces
{
    using System.Collections.Generic;
    using RpgAdventure.Models.Enums;

    public interface IMenu
    {
        int CurrentCursorPosition { get; set; }
        
        ICollection<MenuItem> MenuItems { get; set; }
    }
}
