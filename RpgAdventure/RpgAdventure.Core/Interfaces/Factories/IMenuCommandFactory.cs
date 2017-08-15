namespace RpgAdventure.Core.Interfaces.Factories
{
    public interface IMenuCommandFactory
    {
        ICommand GetCommand(string commandName);
    }
}