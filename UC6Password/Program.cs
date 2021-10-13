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
                return Regex.IsMatch(password, RegexPassword);
            }
        }
        static void Main(string[] args)
        {
            string password;
            bool result;
            Password obj = new Password();

            Console.WriteLine("Enter password");
            password = Console.ReadLine();


            result = obj.Validate(password);
            Console.WriteLine(result);

        }
    }
}
