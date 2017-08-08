using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Models.Interfaces.Factories;

namespace RpgAdventure.Models.Factories
{
    public class PlayableClassFactory : IPlayableClassFactory
    {
        public IPlayableClass Create(string className)
        {
            Type classType = Type.GetType($"RpgAdventure.Models.PlayableClasses.Classes.Specialisations.{className}");
            IPlayableClass classInstance = (IPlayableClass)Activator.CreateInstance(classType);
            return classInstance;

        }
    }
}
