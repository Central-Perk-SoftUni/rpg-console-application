using RpgAdventure.Services.Interfaces.IO;
using System;

namespace RpgAdventure.Services.IO
{
    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}