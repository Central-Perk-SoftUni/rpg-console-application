using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Core.Commands
{
    using RpgAdventure.Core.Interfaces;
    public class ExitCommand : ICommand
    {
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
