namespace RpgAdventure.Models.Classes.Base
{
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    public abstract class Mage : Class
    {
        private static IEnumerable<WeaponType> usableWeaponTypes = new List<WeaponType>()
        {
            WeaponType.Staff
        };

        private static IEnumerable<ArmorMaterial> usableArmorMaterials = new List<ArmorMaterial>()
        {
            ArmorMaterial.Cloth
        };

        private static IStatsInfo baseStatsInfo = new StatsInfo(19, 19, 16, 15);

        protected Mage() : base(usableWeaponTypes, usableArmorMaterials, baseStatsInfo)
        {

        }
    }
}