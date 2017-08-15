using RpgAdventure.Models.Exceptions;

namespace RpgAdventure.Models
{
    using RpgAdventure.Models.Enums;
    using RpgAdventure.Models.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Menu : IMenu
    {
        private const int StartPosition = 1;
        private static readonly ICollection<MenuItem> InitialMenuItems = new List<MenuItem>(Enum.GetValues(typeof(MenuItem)).Cast<MenuItem>());
        private int currentCursorposition;

        public Menu() : this(StartPosition, InitialMenuItems)
        {
        }

        public Menu(int currentCursorPosition, ICollection<MenuItem> menuItems)
        {
            this.CurrentCursorPosition = currentCursorPosition;
            this.MenuItems = menuItems;
        }

        public int CurrentCursorPosition
        {
            get { return this.currentCursorposition; }
            set
            {
                if (value <= 0)
                {
                    throw new NegativeNumberException("Cursor Position");
                }
                this.currentCursorposition = value;
            }
        }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}