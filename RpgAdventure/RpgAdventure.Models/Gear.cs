using System;
using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Interfaces.Items;

namespace RpgAdventure.Models
{
    public class Gear : IGear
    {
        private const string InvalidArmorTypeError = "Armor of type {0} can not go in this slot!";

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
                    throw new ArgumentException(string.Format(InvalidArmorTypeError,value.Type));
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
                    throw new ArgumentException(string.Format(InvalidArmorTypeError, value.Type));
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
                    throw new ArgumentException(string.Format(InvalidArmorTypeError, value.Type));
                }
                this.legs = value;
            }
        }
    }
}
