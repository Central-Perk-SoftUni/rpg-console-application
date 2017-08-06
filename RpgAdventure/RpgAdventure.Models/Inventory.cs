using RpgAdventure.Models.Interfaces;
using RpgAdventure.Utilities;
using System;
using System.Collections.Generic;

namespace RpgAdventure.Models
{
    class Inventory : IInventory
    {
        private int capacity;
        private List<IItem> items;

        public Inventory()
        {
            this.items = new List<IItem>();
            this.capacity = 30;
        }

        public ICollection<IItem> Items => this.items.AsReadOnly();
        
        public bool Add(IItem item)
        {
            if (item == null)
            {
                throw new ArgumentException(Constants.ErrorMessages.ItemCannotBeNull);
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
                throw new ArgumentException(Constants.ErrorMessages.ItemCannotBeNull);
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
