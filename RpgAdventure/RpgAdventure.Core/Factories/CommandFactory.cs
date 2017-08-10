using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Core.Interfaces;
using RpgAdventure.Utilities.Interfaces;

namespace RpgAdventure.Core.Factories
{
    public class CommandFactory : IFactory<ICommand>
    {
        private const string CommandsNamespace = "RpgAdventure.Core.Commands";

        public ICommand Create(string className)
        {
            string commandName = $"{CommandsNamespace}.{className}Command";
            Type commandType = Type.GetType(commandName);
            ICommand result = (ICommand) Activator.CreateInstance(commandType);
            return result;
        }
    }
}
