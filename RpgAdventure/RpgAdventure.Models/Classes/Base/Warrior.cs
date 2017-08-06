namespace RpgAdventure.Models.Classes.Base
{
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    public abstract class Warrior : Class
    {
        private static IEnumerable<WeaponType> usableWeaponTypes = new List<WeaponType>()
        {
            WeaponType.Bow,
            WeaponType.Sword
        };

        private static IEnumerable<ArmorMaterial> usableArmorMaterials = new List<ArmorMaterial>()
        {
            ArmorMaterial.Mail,
            ArmorMaterial.Plate
        };

        private static IStatsInfo baseStatsInfo = new StatsInfo(20, 16, 16, 18);

        protected Warrior() : base(usableWeaponTypes, usableArmorMaterials, baseStatsInfo)
        {

        }
    }
}