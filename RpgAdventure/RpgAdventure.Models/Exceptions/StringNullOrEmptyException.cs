using System;

namespace RpgAdventure.Models.Exceptions
{
    public class StringNullOrEmptyException : Exception
    {
        public const string StringValueCannotBeNullOrEmptyException = "{0} can not be null or empty!";

        public StringNullOrEmptyException(string value) : base(string.Format(StringValueCannotBeNullOrEmptyException, value))
        {
        }
    }
}