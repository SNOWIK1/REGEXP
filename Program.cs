using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password: ");
            string enter = Console.ReadLine();
            string pattern = @"^[a-z]+[A-Z]+[0-9]+[@,$,#]+";   //придется соблюдать последовательность: строчная-прописная-цифра-спецсимвол.

            if (Regex.IsMatch(enter, pattern))
            {
                Console.WriteLine("\nAccess allowed.");
            } else
            {
                Console.WriteLine("\nWRONG PASSWORD.");
            }

            ////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\nEnter a phone number: ");
            string phone = Console.ReadLine();

            string phoneNum = @"^(\+7)(\d{10})$";


            if (Regex.IsMatch(phone, phoneNum))
            {
                Console.WriteLine("\nRight phone number.");
            }
            else
            {
                Console.WriteLine("\nWRONG PHONE NUMBER.");
            }
            /////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\nEnter an email: ");
            string YourEmail= Console.ReadLine(); 
            Regex rgx = new Regex(@"^[-\w.]+@([A-Za-z0-9][-A-Za-z0-9]+\.)+[A-Za-z]{2,4}$"); 
            if (rgx.IsMatch(YourEmail))
            {
                Console.WriteLine("\nRight email syntax!");
            } else
            {
                Console.WriteLine("\nWrong email syntax!");
            }
        }
    }
}
