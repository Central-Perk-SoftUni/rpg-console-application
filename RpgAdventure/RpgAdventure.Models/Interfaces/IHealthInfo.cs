using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Models.Interfaces
{
    public interface IHealthInfo
    {
        int MaxHealth { get; set; }
        int CurrentHealth { get; set; }
    }
}
