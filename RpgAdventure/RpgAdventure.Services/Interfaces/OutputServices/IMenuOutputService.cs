using RpgAdventure.Models.Interfaces;
using RpgAdventure.Utilities;

namespace RpgAdventure.Services.Interfaces.OutputServices
{
    public interface IMenuOutputService
    {
        void ShowMenuItems(IMenu menu, PrintCoordinates coordinates);

        void ShowMenuItems(IMenu menu);

       void ShowCredits();
    }
}