using System;
using System.Collections.Generic;

namespace RpgAdventure.Models.Interfaces
{
    public interface IRace
    {
       ICollection<ICastable> Skills { get; set; }
       ICollection<Type> PlayableClasses { get; set; }
        
    }
}
