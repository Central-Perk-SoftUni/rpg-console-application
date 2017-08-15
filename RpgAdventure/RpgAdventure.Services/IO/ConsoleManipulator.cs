using RpgAdventure.Services.Interfaces.IO;
using System;

namespace RpgAdventure.Services.IO
{
    public class ConsoleManipulator : IConsoleManipulator
    {
        public void ClearScreen()
        {
            Console.Clear();
        }

        public void SetCursorAt(int row, int col)
        {
            Console.SetCursorPosition(col, row);
        }

        public void SetForegroundColorTo(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void SetBackgroundColorTo(ConsoleColor backgroundColor)
        {
            Console.BackgroundColor = backgroundColor;
        }

        public void AlterCursorVisibility(bool isVisible)
        {
            Console.CursorVisible = isVisible;
        }

        public void ResetColor()
        {
            Console.ResetColor();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
    }
}