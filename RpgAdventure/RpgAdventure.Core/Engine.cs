using System;
using System.Collections.Generic;
using System.Linq;
using RpgAdventure.Core.Interfaces;
using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Interfaces.Factories;
using RpgAdventure.Services.Interfaces;
using RpgAdventure.Services.Interfaces.IO;

namespace RpgAdventure.Core
{
    using RpgAdventure.Models;
    using RpgAdventure.Models.Interfaces;
    using RpgAdventure.Services;

    public class Engine : IEngine
    {
        private readonly ICommandParser commandParser;
        private readonly IConsoleManipulator consoleManipulator;
        private readonly IMenuService menuService;
        private readonly IMenu menu;

        public Engine(ICommandParser commandParser, IMenuService menuService, IConsoleManipulator consoleManipulator, IMenu menu)
        {
            this.commandParser = commandParser;
            this.consoleManipulator = consoleManipulator;
            this.menuService = menuService;
            this.menu = menu;
        }

        public void Run()
        {
            while (true)
            {
                this.menuService.ShowMenuItems(menu);
                ConsoleKeyInfo pressedKey = this.consoleManipulator.ReadKey();
                this.NavigateMenu(this.menu,pressedKey);
                this.consoleManipulator.ClearScreen();
                
            }
        }

        private void NavigateMenu(IMenu menu, ConsoleKeyInfo pressedKey)
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
            this.commandParser.ParseCommand(Enum.GetName(typeof(MenuItem), currentMenuOption));
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
