using System;
using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Exceptions;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Interfaces.Items;

namespace RpgAdventure.Models
{
    public class Gear : IGear
    {
        private IArmor chest;
        private IArmor head;
        private IArmor legs;

        public Gear(IWeapon weapon, IArmor chest, IArmor head, IArmor legs)
        {
            this.Weapon = weapon;
            this.Chest = chest;
            this.Head = head;
            this.Legs = legs;
        }

        public IWeapon Weapon { get; set; }

        public IArmor Chest
        {
            get { return this.chest; }
            set
            {
                if (value.Type != ArmorType.Chest)
                {
                    throw new InvalidTypeOfArmorException(Enum.GetName(typeof(ArmorType),value));
                }
                this.chest = value;
            }
        }

        public IArmor Head
        {
            get { return this.head; }
            set
            {
                if (value.Type != ArmorType.Head)
                {
                    throw new InvalidTypeOfArmorException(Enum.GetName(typeof(ArmorType), value));
                }
                this.head = value;
            }
        }

        public IArmor Legs
        {
            get { return this.legs; }
            set
            {
                if (value.Type != ArmorType.Legs)
                {
                    throw new InvalidTypeOfArmorException(Enum.GetName(typeof(ArmorType), value));
                }
                this.legs = value;
            }
        }
    }
}
