using System.Collections.Generic;
using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models.PlayableClasses.Classes
{
    public abstract class Mage : PlayableClass
    {
        private static readonly ICollection<ICastable> baseSkills = new List<ICastable>()
        {

        };

        private static readonly ICollection<WeaponType> usableWeaponTypes = new List<WeaponType>()
        {
            WeaponType.Staff
        };

        private static readonly ICollection<ArmorMaterial> usableArmorMaterials = new List<ArmorMaterial>()
        {
            ArmorMaterial.Cloth
        };

        private static IStatsInfo baseStatsInfo = new StatsInfo(19, 19, 16, 15);

        protected Mage() : this(baseSkills, usableWeaponTypes, usableArmorMaterials, baseStatsInfo)
        {

        }

        protected Mage(ICollection<ICastable> skills, ICollection<WeaponType> weaponTypes, ICollection<ArmorMaterial> armorMaterials,
            IStatsInfo baseStats) : base(skills, weaponTypes, armorMaterials, baseStats)
        {

        }
    }
}