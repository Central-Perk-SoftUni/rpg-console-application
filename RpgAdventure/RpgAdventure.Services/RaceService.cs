using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Races;
using RpgAdventure.Services.Interfaces;

namespace RpgAdventure.Services
{
    public class RaceService : IRaceService
    {
        public ICollection<Type> GetAllRaces()
        {
            return Assembly.GetAssembly(typeof(Race)).GetTypes().Where(t => t.IsSubclassOf(typeof(Race))).ToList();
        }
    }
}
