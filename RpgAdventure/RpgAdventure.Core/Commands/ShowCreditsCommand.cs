using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Core.Commands
{
    using RpgAdventure.Core.Interfaces;
    using RpgAdventure.Services;

    public class ShowCreditsCommand : ICommand
    {
        private readonly MenuService menuService;

        public ShowCreditsCommand(MenuService menuService)
        {
            this.menuService = menuService;
        }

        public void Execute()
        {
            this.menuService.ShowCredits();
        }
    }
}
