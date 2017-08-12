using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgAdventure.Models.Exceptions
{
    public class NegativeNumberException : Exception
    {
        private const string NegativeNumberExceptionMessage = "{0} can not be negative!";

        public NegativeNumberException(string value) : base(string.Format(NegativeNumberExceptionMessage,value))
        {
            
        }
    }
}
