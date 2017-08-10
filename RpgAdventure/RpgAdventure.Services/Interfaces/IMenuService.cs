using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Services.Interfaces
{
    public interface IMenuService
    {
        void ShowMenuItems(IMenu menu);
        void ShowCredits();


    }
}
