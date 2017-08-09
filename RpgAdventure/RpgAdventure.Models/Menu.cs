namespace RpgAdventure.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RpgAdventure.Models.Enums;
    using RpgAdventure.Models.Interfaces;

    public class Menu : IMenu
    {
        public Menu()
        {
            this.CurrentCursorPosition = 1;
            this.MenuItems = new HashSet<MenuItem>(Enum.GetValues(typeof(MenuItem)).Cast<MenuItem>());
        }

        public int CurrentCursorPosition { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
