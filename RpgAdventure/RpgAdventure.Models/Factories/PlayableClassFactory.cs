using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Interfaces;
using RpgAdventure.Utilities.Interfaces;

namespace RpgAdventure.Models.Factories
{
    
    public class PlayableClassFactory : IFactory<IPlayableClass>
    {
        private const string PlayableClassesNamespace = "RpgAdventure.Models.PlayableClasses.Classes.Specialisations";

        public IPlayableClass Create(string className)
        {
            Type classType = Type.GetType($"{PlayableClassesNamespace}.{className}");
            IPlayableClass classInstance = (IPlayableClass)Activator.CreateInstance(classType);
            return classInstance;

        }
    }
}
