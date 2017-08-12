using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Models.Interfaces.Factories
{
    public interface IPlayableClassFactory
    {
        IPlayableClass GetPlayableClass(string playableClass);
    }
}
