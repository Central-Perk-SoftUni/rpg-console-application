using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using RpgAdventure.Core.Interfaces;
using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Services.Interfaces.IO;

namespace RpgAdventure.Core
{
    public class MenuNavigator : IMenuNavigator
    {
        private readonly IConsoleManipulator consoleManipulator;
        private readonly IMenuCommandParser menuCommandParser;

        public MenuNavigator(IConsoleManipulator consoleManipulator, IMenuCommandParser menuCommandParser)
        {
            this.consoleManipulator = consoleManipulator;
            this.menuCommandParser = menuCommandParser;
        }

        public void NavigateMenu(IMenu menu, ConsoleKeyInfo pressedKey)
        {
            if (pressedKey.Key == ConsoleKey.DownArrow)
            {
                this.TryMoveMenuPositionDown(menu);
            }
            else if (pressedKey.Key == ConsoleKey.UpArrow)
            {
                this.TryMoveMenuPositionUp(menu);
            }
            else if (pressedKey.Key == ConsoleKey.Enter)
            {
                this.ExecuteCurrentMenuCommand(menu);
            }
        }

        private void ExecuteCurrentMenuCommand(IMenu menu)
        {
            MenuItem currentMenuOption = menu.MenuItems.ElementAt(menu.CurrentCursorPosition - 1);
            this.consoleManipulator.ClearScreen();
            this.menuCommandParser.ParseCommand(Enum.GetName(typeof(MenuItem), currentMenuOption));
        }

        private void TryMoveMenuPositionUp(IMenu menu)
        {
            if (menu.CurrentCursorPosition > 1)
            {
                menu.CurrentCursorPosition--;
            }
        }

        private void TryMoveMenuPositionDown(IMenu menu)
        {
            if (menu.CurrentCursorPosition < menu.MenuItems.Count)
            {
                menu.CurrentCursorPosition++;
            }
        }
    }
}
