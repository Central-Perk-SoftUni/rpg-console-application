namespace RpgAdventure.Models.Interfaces
{
    public interface IEnemy
    {
        string Name { get; }
        IHealthInfo HealthInfo { get; }
        int AttackDamage { get; set; }
        int Level { get; }
    }
}