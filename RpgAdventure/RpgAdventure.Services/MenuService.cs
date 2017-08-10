﻿using RpgAdventure.Models.Enums;
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
        private IWriter writer;

        public MenuService(IWriter writer)
        {
            this.writer = writer;
        }

        public void ShowMenuItems(IMenu menu)
        {
            Console.CursorVisible = false;
            var counter = 1;
            
            foreach (var menuItem in menu.MenuItems)
            {
                Console.SetCursorPosition(22, 8 + counter);
                if (menu.CurrentCursorPosition == counter)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    this.writer.WriteLine($"{this.GetMenuItemDescription(menuItem)}");
                    Console.ResetColor();
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