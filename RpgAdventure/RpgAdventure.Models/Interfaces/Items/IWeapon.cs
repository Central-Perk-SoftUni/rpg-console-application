using RpgAdventure.Models.Enums;

namespace RpgAdventure.Models.Interfaces.Items
{
    public interface IWeapon : IItem
    {
        int AttackDamage { get; set; }
        WeaponType Type { get; set; }
    }
}