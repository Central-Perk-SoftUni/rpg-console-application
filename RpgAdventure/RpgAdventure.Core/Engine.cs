using System;
using System.Collections.Generic;
using System.Linq;
using RpgAdventure.Core.Interfaces;
using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Interfaces.Factories;
using RpgAdventure.Services.Interfaces;

namespace RpgAdventure.Core
{
    using RpgAdventure.Models;
    using RpgAdventure.Models.Interfaces;
    using RpgAdventure.Services;

    public class Engine : IEngine
    {
        private readonly ICommandParser commandParser;
        private readonly IMenuService menuService;

        public Engine(ICommandParser commandParser, IMenuService menuService)
        {
            this.commandParser = commandParser;
            this.menuService = menuService;
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
                    MenuItem currentMenuOption = menu.MenuItems.ElementAt(menu.CurrentCursorPosition - 1);
                    this.commandParser.ParseCommand(Enum.GetName(typeof(MenuItem), currentMenuOption));
                }
                Console.Clear();
                this.menuService.ShowMenuItems(menu);
                pressedKey = Console.ReadKey();
            }
        }


    }
}
