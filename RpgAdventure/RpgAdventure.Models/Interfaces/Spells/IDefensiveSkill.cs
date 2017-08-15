namespace RpgAdventure.Models.Interfaces.Spells
{
    public interface IDefensiveSkill : ICastable
    {
        int HealingDealt { get; set; }

        void Cast(IPlayer target);
    }
}