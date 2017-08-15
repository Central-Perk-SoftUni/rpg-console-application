using System;

namespace RpgAdventure.Models.Exceptions
{
    public class InvalidTypeOfArmorException : Exception
    {
        private const string InvalidTypeOfArmorExceptionMessage = "Armor of type {0} can not go in this slot!";

        public InvalidTypeOfArmorException(string value) : base(string.Format(InvalidTypeOfArmorExceptionMessage, value))
        {
        }
    }
}