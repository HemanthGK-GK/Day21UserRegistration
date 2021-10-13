using System;
using System.Text.RegularExpressions;

namespace UC7Password
{
    class Program
    {
        class Password
        {
            public string RegexPassword = "^(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z]{8,}$";


            public bool Validate(string password)
            {
                return Regex.IsMatch(password, RegexPassword);
            }
        }
        static void Main(string[] args)
        {
            string password;
            bool result;
            Password obj = new Password();

            Console.WriteLine("Enter password ");
            Console.WriteLine("It Must Contain 1 Numeric value");
            Console.WriteLine("It Must Contain 1 UpperCase letter");
            password = Console.ReadLine();


            result = obj.Validate(password);
            Console.WriteLine(result);

        }
    }
}

