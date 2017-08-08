using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgAdventure.Models.Interfaces;

namespace RpgAdventure.Models
{
    public class HealthInfo : IHealthInfo
    {
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
    }
}
