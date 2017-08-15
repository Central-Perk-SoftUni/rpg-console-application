using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Core.Interfaces
{
    public interface IMenuNavigator
    {
        void NavigateMenu(IMenu menu, ConsoleKeyInfo pressedKey);
    }
}
