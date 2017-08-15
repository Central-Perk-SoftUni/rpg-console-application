using System;
using System.ComponentModel;
using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Services.Interfaces.IO;
using RpgAdventure.Services.Interfaces.OutputServices;
using RpgAdventure.Utilities;

namespace RpgAdventure.Services.OutputServices
{
    public class MenuOutputService : IMenuOutputService
    {
        private readonly IWriter writer;
        private readonly IConsoleManipulator consoleManipulator;

        public MenuOutputService(IWriter writer, IConsoleManipulator consoleManipulator)
        {
            this.writer = writer;
            this.consoleManipulator = consoleManipulator;
        }


        public void ShowMenuItems(IMenu menu)
        {
            this.ShowMenuItems(menu, new PrintCoordinates(Constants.OutputRow,Constants.OutputCol));
        }


        public void ShowMenuItems(IMenu menu, PrintCoordinates coordinates)
        {
            consoleManipulator.AlterCursorVisibility(false);
            var counter = 1;

            foreach (var menuItem in menu.MenuItems)
            {
                consoleManipulator.SetCursorAt(coordinates.OutputRow + counter, coordinates.OutputCol);
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