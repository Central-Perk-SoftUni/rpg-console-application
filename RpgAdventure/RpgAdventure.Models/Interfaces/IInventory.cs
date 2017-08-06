using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Interfaces.Items;

namespace RpgAdventure.Models.Interfaces
{
    interface IInventory
    {
        ICollection<IItem> Items { get; }
    }
}
