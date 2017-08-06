namespace RpgAdventure.Models.Interfaces
{
    interface ICastable
    {
        void TryCast<T>(T target);
    }
}
