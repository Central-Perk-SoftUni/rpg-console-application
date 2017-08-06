namespace RpgAdventure.Models.Classes.Sub
{
    using Base;
    using Skills;

    public class ArcaneMage : Mage
    {
        public ArcaneMage() :base()
        {
            base.AddSkill(new DamagingSkill("Arcane blast", 1, 1, 1));
            base.AddSkill(new DamagingSkill("Arcane Barrage", 1, 1, 1));
        }
    }
}