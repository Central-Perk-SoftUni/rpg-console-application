namespace RpgAdventure.Models.Interfaces
{
    using Enums;
    using System.Collections.Generic;

    public interface IPlayableClass
    {
        ICollection<ICastable> Skills { get; }
        ICollection<WeaponType> UsableWeaponTypes { get; }
        ICollection<ArmorMaterial> UsableArmorMaterials { get; }
        IStatsInfo BaseStats { get; }
    }
}