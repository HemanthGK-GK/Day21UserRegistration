using System;
using System.Text.RegularExpressions;

namespace UC6Password
{
    class Program
    {
        class Password
        {
            public string RegexPassword = "^(?=.*[A-Z])+[0-9a-zA-Z]{7,}$";


            public bool Validate(string password)
            {
                if(password == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.INVALID_MESSAGE, "Invalid Password");
            }
            return Regex.IsMatch(password, Regex_PSWD);
            }
        }
       
    }
}
