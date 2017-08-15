namespace RpgAdventure.Models.Interfaces
{
    public interface ICastable
    {
        string Name { get; }
        int ManaCost { get; set; }
    }
}