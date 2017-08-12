using System;
using RpgAdventure.Services.Interfaces.IO;

namespace RpgAdventure.Services.IO
{
    public class ConsoleManipulator : IConsoleManipulator
    {
        public void ClearScreen()
        {
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
    }
}
