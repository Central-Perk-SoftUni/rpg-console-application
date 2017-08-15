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
        private readonly IMenuNavigator menuNavigator;
        private readonly IConsoleManipulator consoleManipulator;
        private readonly IMenuService menuService;
        private readonly IMenu menu;

        public Engine(IMenuNavigator menuNavigator, IMenuService menuService, IConsoleManipulator consoleManipulator, IMenu menu)
        {
            this.menuNavigator = menuNavigator;
            this.consoleManipulator = consoleManipulator;
            this.menuService = menuService;
            this.menu = menu;
        }

        public void Run()
        {
            while (true)
            {
                this.menuService.ShowMenuItems(this.menu);
                ConsoleKeyInfo pressedKey = this.consoleManipulator.ReadKey();
                this.menuNavigator.NavigateMenu(this.menu,pressedKey);
                this.consoleManipulator.ClearScreen();
                
            }
        }


    }
}
