using System;
using System.Text.RegularExpressions;

namespace UC4RegExPhoneNum
{
    class Program
    {
        class Phone
        {
            public string RegexPhone = "^[9]{1}[1]{1}[ ]{1}[0-9]{10}$";
           

            public bool Validate(string Phone)
            {
               if(phonenumber == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.INVALID_MESSAGE, "Invalid Email ID");
            }
            return Regex.IsMatch(phonenumber, Regex_MobileNumber);
            }
        }
       
    }
}
