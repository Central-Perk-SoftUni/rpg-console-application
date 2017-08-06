namespace RpgAdventure.Models
{
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    public abstract class Class : IClass
    {
        private IList<ICastable> skills;
        private IList<WeaponType> usableWeaponTypes;
        private IList<ArmorMaterial> usableArmorMaterials;
        private IStatsInfo baseStats;

        protected Class(IEnumerable<WeaponType> usableWeaponTypes, IEnumerable<ArmorMaterial> usableArmorMaterials, IStatsInfo baseStats)
        {
            this.skills = new List<ICastable>();
            this.usableWeaponTypes = new List<WeaponType>(usableWeaponTypes);
            this.usableArmorMaterials = new List<ArmorMaterial>(usableArmorMaterials);
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