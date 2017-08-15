using RpgAdventure.Models.Interfaces.Items;
using System.Collections.Generic;

namespace RpgAdventure.Models.Interfaces
{
    public interface IInventory
    {
        ICollection<IItem> Items { get; }
    }
}