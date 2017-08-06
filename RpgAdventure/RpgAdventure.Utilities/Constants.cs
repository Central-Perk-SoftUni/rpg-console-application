using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Utilities
{
    public class Constants
    {
        public class ErrorMessages
        {
            public const string NumericValueCannotBeNegative = "{0} can not be negative!";
            public const string LevelMustBeBetweenOneAndSixty = "Level must be between 1 and 60!";
            public const string TotalExperienceCannotBeLessThanCurrentExperience = "Total Experience can not be less than current experience!";
            public const string ItemCannotBeNull = "Item can not be null!";
        }
    }
}
