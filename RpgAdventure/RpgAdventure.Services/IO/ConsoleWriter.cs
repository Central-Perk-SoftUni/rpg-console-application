using RpgAdventure.Services.Interfaces.IO;
using System;

namespace RpgAdventure.Services.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}