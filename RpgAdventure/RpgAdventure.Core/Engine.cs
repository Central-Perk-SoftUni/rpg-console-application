using System;
using RpgAdventure.Core.Interfaces;

namespace RpgAdventure.Core
{
    using RpgAdventure.Models;
    using RpgAdventure.Models.Interfaces;
    using RpgAdventure.Services;

    public class Engine : IEngine
    {
        private readonly ICommandParser commandParser;
        private readonly MenuService menuService;

        public Engine()
        {
            this.commandParser = new CommandParser();
            this.menuService = new MenuService();
        }

        public void Run()
        {
            IMenu menu = new Menu();
            var pressedKey = new ConsoleKeyInfo();
            while (true)
            {
                Console.Clear();
                if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (menu.CurrentCursorPosition < menu.MenuItems.Count)
                    {
                        menu.CurrentCursorPosition++;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (menu.CurrentCursorPosition > 1)
                    {
                        menu.CurrentCursorPosition--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.Enter)
                {
                    this.commandParser.ParseCommand(menu.CurrentCursorPosition);
                }
                Console.Clear();
                this.menuService.ShowMenuItems(menu);
                pressedKey = Console.ReadKey();
            }
        }
    }
}
