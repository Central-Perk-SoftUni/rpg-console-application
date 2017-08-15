namespace RpgAdventure.Models.PlayableClasses
{
    using Enums;
    using Interfaces;
    using System.Collections.Generic;

    public abstract class PlayableClass : IPlayableClass
    {
        private ICollection<ICastable> skills;
        private ICollection<WeaponType> usableWeaponTypes;
        private ICollection<ArmorMaterial> usableArmorMaterials;
        private IStatsInfo baseStats;

        protected PlayableClass(ICollection<ICastable> skills, ICollection<WeaponType> usableWeaponTypes, ICollection<ArmorMaterial> usableArmorMaterials, IStatsInfo baseStats)
        {
            this.skills = skills;
            this.usableWeaponTypes = usableWeaponTypes;
            this.usableArmorMaterials = usableArmorMaterials;
            this.baseStats = baseStats;
        }

        public ICollection<ICastable> Skills => this.skills;

        public ICollection<WeaponType> UsableWeaponTypes => this.usableWeaponTypes;

        public ICollection<ArmorMaterial> UsableArmorMaterials => this.usableArmorMaterials;

        public IStatsInfo BaseStats => this.baseStats;

        public void AddSkill(ICastable skill)
        {
            this.skills.Add(skill);
        }
    }
}