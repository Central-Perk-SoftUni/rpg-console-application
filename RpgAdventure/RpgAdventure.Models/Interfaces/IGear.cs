using RpgAdventure.Models.Interfaces.Items;

namespace RpgAdventure.Models.Interfaces
{
    public interface IGear
    {
        IWeapon Weapon { get; set; }
        IArmor Chest { get; set; }
        IArmor Head { get; set; }
        IArmor Legs { get; set; }
    }
}