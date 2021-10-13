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
                return Regex.IsMatch(firstname, RegexFirstName);
            }

        }
        static void Main(string[] args)
        {
            string FirstName;
            bool result;
            ChkFirstName obj = new ChkFirstName();

            Console.WriteLine("Enter FirstName");
            FirstName = Console.ReadLine();


            result = obj.Validate(FirstName);
            Console.WriteLine(result);
        }
    }
}
