using System;
using System.Text.RegularExpressions;

namespace UC3RegExEmail
{
    class Program
    {
        class ChkEmail
        {
            public string RegexEmail = "^[a-zA-Z0-9]{2,}[.]+([a-zA-Z0-9]+)*[@][a-zA-Z0-9]{2,}+[.][a-zA-Z]{2,3}+([.][a-zA-Z]{2}+)$";
            public bool Validate(string email)
            {
                if(email == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.INVALID_MESSAGE, "Invalid Email");
            }
            return Regex.IsMatch(email, Regex_Email); 
            }

        }
      
    }
}
