namespace RpgAdventure.Models.Interfaces.Spells
{
    public interface IOffensiveSKill : ICastable
    {
        int DamageDealt { get; set; }

        void Cast(IEnemy target);
    }
}