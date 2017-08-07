using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Services.Interfaces.IO;

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
