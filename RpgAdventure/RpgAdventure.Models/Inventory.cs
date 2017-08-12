using RpgAdventure.Models.Interfaces;
using System;
using System.Collections.Generic;
using RpgAdventure.Models.Interfaces.Items;

namespace RpgAdventure.Models
{
    public class Inventory : IInventory
    {
        public const string ItemCannotBeNull = "Item can not be null!";

        private int capacity;
        private readonly ICollection<IItem> items;

        public Inventory(ICollection<IItem> items, int capacity)
        {
            this.items = items;
            this.capacity = capacity;
        }

        public ICollection<IItem> Items => this.items;
        
        public bool Add(IItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(ItemCannotBeNull);
            }
            if (this.items.Count == capacity)
            {
                return false;
            }
            this.items.Add(item);
            return true;
        }

        public bool Remove(IItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(ItemCannotBeNull);
            }
            if (!this.items.Contains(item))
            {
                return false;
            }
            this.items.Remove(item);
            return true;
        }
    }
}
