namespace RpgAdventure.Models.Classes.Base
{
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    public abstract class Hunter : Class
    {
        private static IEnumerable<WeaponType> usableWeaponTypes = new List<WeaponType>()
        {
            WeaponType.Bow
        };

        private static IEnumerable<ArmorMaterial> usableArmorMaterials = new List<ArmorMaterial>()
        {
            ArmorMaterial.Cloth,
            ArmorMaterial.Mail
        };

        private static IStatsInfo baseStatsInfo = new StatsInfo(21, 16, 19, 16);

        protected Hunter() : base(usableWeaponTypes, usableArmorMaterials, baseStatsInfo)
        {

        }
    }
}