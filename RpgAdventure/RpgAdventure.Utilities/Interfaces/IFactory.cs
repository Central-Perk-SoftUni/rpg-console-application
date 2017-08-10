namespace RpgAdventure.Utilities.Interfaces
{
    public interface IFactory<T>
    {
        T Create(string className);
    }
}
