using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Interfaces;
using System.Collections.Generic;

namespace RpgAdventure.Models.PlayableClasses.Classes
{
    public abstract class Warrior : PlayableClass
    {
        private static readonly ICollection<ICastable> baseSkills = new List<ICastable>()
        {
        };

        private static readonly ICollection<WeaponType> usableWeaponTypes = new List<WeaponType>()
        {
            WeaponType.Bow,
            WeaponType.Sword
        };

        private static readonly ICollection<ArmorMaterial> usableArmorMaterials = new List<ArmorMaterial>()
        {
            ArmorMaterial.Mail,
            ArmorMaterial.Plate
        };

        private static readonly IStatsInfo baseStatsInfo = new StatsInfo(20, 16, 16, 18);

        protected Warrior() : this(baseSkills, usableWeaponTypes, usableArmorMaterials, baseStatsInfo)
        {
        }

        protected Warrior(ICollection<ICastable> skills, ICollection<WeaponType> weaponTypes, ICollection<ArmorMaterial> armorMaterials,
            IStatsInfo baseStats) : base(skills, weaponTypes, armorMaterials, baseStats)
        {
        }
    }
}