using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Services.Interfaces
{
    public interface IRaceService
    {
        ICollection<Type> GetAllRaces();
    }
}
