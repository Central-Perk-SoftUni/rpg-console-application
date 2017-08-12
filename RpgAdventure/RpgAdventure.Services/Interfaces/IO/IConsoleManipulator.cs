using System;

namespace RpgAdventure.Services.Interfaces.IO
{
    public interface IConsoleManipulator
    {
        void ClearScreen();

        ConsoleKeyInfo ReadKey();
    }
}
