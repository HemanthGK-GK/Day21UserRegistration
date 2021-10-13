using System;
using System.Text.RegularExpressions;

namespace UC2RegExLastName
{
    class Program
    {
        class ChkLastName
        {
            public string RegexLastName = "^[A-Z]{1}[a-z]{2,}$";
            public bool Validate(string lastname)
            {
                if (lastname == null)
            {
                throw new CustomException.UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.INVALID_MESSAGE, "Invalid LastName");
            }
            return Regex.IsMatch(lastname, Regex_Lastname);
            }

        }
        
    }
}
