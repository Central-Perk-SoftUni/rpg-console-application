using RpgAdventure.Models.Enums;
using RpgAdventure.Services.Interfaces;
using RpgAdventure.Services.Interfaces.IO;

namespace RpgAdventure.Services
{
    using System;
    using System.ComponentModel;
    using RpgAdventure.Models.Interfaces;
    using RpgAdventure.Services.IO;

    public class MenuService : IMenuService
    {
        private readonly IWriter writer;
        private readonly IConsoleManipulator consoleManipulator;

        public MenuService(IWriter writer, IConsoleManipulator consoleManipulator)
        {
            this.writer = writer;
            this.consoleManipulator = consoleManipulator;
        }

        public void ShowMenuItems(IMenu menu)
        {
            consoleManipulator.AlterCursorVisibility(false);
            var counter = 1;
            
            foreach (var menuItem in menu.MenuItems)
            {
                consoleManipulator.SetCursorAt(8 + counter,22);
                if (menu.CurrentCursorPosition == counter)
                {
                    consoleManipulator.SetBackgroundColorTo(ConsoleColor.DarkGray);
                    consoleManipulator.SetForegroundColorTo(ConsoleColor.White);
                    this.writer.WriteLine($"{this.GetMenuItemDescription(menuItem)}");
                    consoleManipulator.ResetColor();
                }
                else
                {
                    this.writer.WriteLine($"{this.GetMenuItemDescription(menuItem)}");
                }
                counter++;
            }
        }

        private string GetMenuItemDescription(MenuItem enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return enumValue.ToString();
        }

        public void ShowCredits()
        {
            // TO DO...
        }
    }
}
