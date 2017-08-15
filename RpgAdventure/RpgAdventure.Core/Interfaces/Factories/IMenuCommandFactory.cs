using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Core.Interfaces.Factories
{
    public interface IMenuCommandFactory
    {
        ICommand GetCommand(string commandName);
    }
}
