using RpgAdventure.Core.Interfaces;
using RpgAdventure.Services.Interfaces;
using RpgAdventure.Services.Interfaces.IO;
using System;
using RpgAdventure.Services.Interfaces.OutputServices;

namespace RpgAdventure.Core
{
    using RpgAdventure.Models.Interfaces;

    public class Engine : IEngine
    {
        private readonly IMenuNavigator menuNavigator;
        private readonly IConsoleManipulator consoleManipulator;
        private readonly IMenuOutputService menuOutputService;
        private readonly IMenu menu;

        public Engine(IMenuNavigator menuNavigator, IMenuOutputService menuOutputService, IConsoleManipulator consoleManipulator, IMenu menu)
        {
            this.menuNavigator = menuNavigator;
            this.consoleManipulator = consoleManipulator;
            this.menuOutputService = menuOutputService;
            this.menu = menu;
        }

        public void Run()
        {
            while (true)
            {
                this.menuOutputService.ShowMenuItems(this.menu);
                ConsoleKeyInfo pressedKey = this.consoleManipulator.ReadKey();
                this.menuNavigator.NavigateMenu(this.menu, pressedKey);
                this.consoleManipulator.ClearScreen();
            }
        }
    }
}