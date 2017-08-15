using RpgAdventure.Models.Enums;
using RpgAdventure.Models.Interfaces;
using System.Collections.Generic;

namespace RpgAdventure.Models.PlayableClasses.Classes
{
    public abstract class Hunter : PlayableClass
    {
        private static readonly ICollection<ICastable> baseSkills = new List<ICastable>()
        {
        };

        private static readonly ICollection<WeaponType> usableWeaponTypes = new List<WeaponType>()
        {
            WeaponType.Bow
        };

        private static readonly ICollection<ArmorMaterial> usableArmorMaterials = new List<ArmorMaterial>()
        {
            ArmorMaterial.Cloth,
            ArmorMaterial.Mail
        };

        private static readonly IStatsInfo baseStatsInfo = new StatsInfo(21, 16, 19, 16);

        protected Hunter() : this(baseSkills, usableWeaponTypes, usableArmorMaterials, baseStatsInfo)
        {
        }

        protected Hunter(ICollection<ICastable> skills, ICollection<WeaponType> weaponTypes, ICollection<ArmorMaterial> armorMaterials,
            IStatsInfo baseStats) : base(skills, weaponTypes, armorMaterials, baseStats)
        {
        }
    }
}