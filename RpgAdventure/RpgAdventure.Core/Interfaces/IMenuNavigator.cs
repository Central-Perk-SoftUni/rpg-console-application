using RpgAdventure.Models.Interfaces;
using System;

namespace RpgAdventure.Core.Interfaces
{
    public interface IMenuNavigator
    {
        void NavigateMenu(IMenu menu, ConsoleKeyInfo pressedKey);
    }
}