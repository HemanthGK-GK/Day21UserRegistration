using System;
using System.Collections.Generic;
using System.Text;

namespace UC1RegExFirstName
{
   public class CustomException : Exception
    {
        public enum ExceptionsType
        {
            INVALID_MESSAGE
        }
        public ExceptionsType type;
        public CustomException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;

        }
    }
}
