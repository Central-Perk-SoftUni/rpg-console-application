using RpgAdventure.Models.Enums;

namespace RpgAdventure.Models.Interfaces.Items
{
    public interface IWeapon : IItem
    {
        WeaponType Type { get; set; }
    }
}
