namespace RpgAdventure.Models.Interfaces
{
    using System.Collections.Generic;
    using Enums;

    public interface IPlayableClass
    {
        ICollection<ICastable> Skills { get; }
        ICollection<WeaponType> UsableWeaponTypes { get; }
        ICollection<ArmorMaterial> UsableArmorMaterials { get; }
        IStatsInfo BaseStats { get; }
    }
}