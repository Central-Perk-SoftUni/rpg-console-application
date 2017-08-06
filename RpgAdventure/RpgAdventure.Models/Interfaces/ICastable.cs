namespace RpgAdventure.Models.Interfaces
{
    public interface ICastable
    {
        string Name { get; }
        void TryCast<T>(T target);
    }
}
