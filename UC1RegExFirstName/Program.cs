using System;
using System.Text.RegularExpressions;

namespace UC1RegExFirstName
{
    class Program
    {
        class ChkFirstName
        {
            public string RegexFirstName = "^[A-Z]{1}[a-z]{2,}$";
            public bool Validate(string firstname)
            {
                 if (firstName == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.INVALID_MESSAGE, "Invalid FirstName");
            }
            return Regex.IsMatch(firstName, Regex_Firstname);
            }

        }
        
    }
}
