﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UC3RegExEmail
{
   public class CustomException : Exception
    {
        public enum ExceptionsType
        {
            invalid_data
        }
        public ExceptionsType type;
        public CustomException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;

        }
    }
}