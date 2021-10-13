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
                return Regex.IsMatch(Phone, RegexPhone);
            }
        }
        static void Main(string[] args)
        {
            string Phone;
            bool result;
            Phone obj = new Phone();

            Console.WriteLine("Enter Phone number");
            Phone = Console.ReadLine();


            result = obj.Validate(Phone);
            Console.WriteLine(result);

        }
    }
}
