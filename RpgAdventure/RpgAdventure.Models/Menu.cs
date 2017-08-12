namespace RpgAdventure.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RpgAdventure.Models.Enums;
    using RpgAdventure.Models.Interfaces;

    public class Menu : IMenu
    {
        private const int StartPosition = 1;
        private static readonly ICollection<MenuItem> InitialMenuItems = new List<MenuItem>(Enum.GetValues(typeof(MenuItem)).Cast<MenuItem>());

        public Menu() : this(StartPosition, InitialMenuItems)
        {
            
        }

        public Menu(int currentCursorPosition, ICollection<MenuItem> menuItems)
        {
            this.CurrentCursorPosition = currentCursorPosition;
            this.MenuItems = menuItems;
        }

        public int CurrentCursorPosition { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
