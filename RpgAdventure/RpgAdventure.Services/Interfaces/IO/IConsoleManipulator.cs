using System;

namespace RpgAdventure.Services.Interfaces.IO
{
    public interface IConsoleManipulator
    {
        void ClearScreen();
        void SetCursorAt(int row, int col);
        void SetForegroundColorTo(ConsoleColor color);
        void SetBackgroundColorTo(ConsoleColor backgroundColor);
        void AlterCursorVisibility(bool isVisible);
        void ResetColor();
        ConsoleKeyInfo ReadKey();
    }
}
