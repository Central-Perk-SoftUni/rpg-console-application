namespace RpgAdventure.Models.Classes.Sub
{
    using Base;
    using Skills;

    public class FireMage : Mage
    {
        public FireMage() :base()
        {
            base.AddSkill(new DamagingSkill("Pyroblast", 1, 1, 1));
            base.AddSkill(new DamagingSkill("Combustion", 1, 1, 1));
        }
    }
}