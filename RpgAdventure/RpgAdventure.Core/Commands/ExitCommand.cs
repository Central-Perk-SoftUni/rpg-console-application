using System;

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