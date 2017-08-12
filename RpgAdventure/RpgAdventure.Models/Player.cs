using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Exceptions;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models
{
    public class Player : IPlayer
    {
        private string name;

        public Player(IPlayableClass playerClass, IRace race, string name, IInventory inventory, IHealthInfo healthInfo, IGear equippedItems, ILevelInfo levelInfo)
        {
            this.Class = playerClass;
            this.Race = race;
            this.Name = name;
            this.Inventory = inventory;
            this.HealthInfo = healthInfo;
            this.EquippedItems = equippedItems;
            this.LevelInfo = levelInfo;
        }
        public IPlayableClass Class { get; set; }
        public IRace Race { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new StringNullOrEmptyException("Name");
                }
                this.name = value;
            }
        }

        public IInventory Inventory { get; set; }
        public IHealthInfo HealthInfo { get; set; }
        public IGear EquippedItems { get; set; }
        public ILevelInfo LevelInfo { get; set; }
    }
}
