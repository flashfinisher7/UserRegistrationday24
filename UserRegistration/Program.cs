using System;
using System.Collections.Generic;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t This Is User Registration problem");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("0.Exit\n1.First Name Validation\n2.Last Name Validation\n3.Email Validation\n4.Mobile Number Validation\n5.Password Validation\n6.Validating Sample emails");
                Console.WriteLine("Choose an option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                User user = new User();
                bool result;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first name : ");
                        string firstName = Console.ReadLine();
                        result = user.ValidateFirstName(firstName);
                        if (result)
                            Console.WriteLine("It is valid");
                        else
                            Console.WriteLine("It is not valid");
                        break;
                    case 2:
                        Console.WriteLine("Enter last name : ");
                        string lastName = Console.ReadLine();
                        result = user.ValidateLastName(lastName);
                        if (result)
                            Console.WriteLine("It is valid");
                        else
                            Console.WriteLine("It is not valid");
                        break;
                    case 3:
                        Console.WriteLine("Enter email");
                        string email = Console.ReadLine();
                        result = user.ValidateEmail(email);
                        if (result)
                            Console.WriteLine("It is valid");
                        else
                            Console.WriteLine("It is not valid");
                        break;
                    case 4:
                        Console.WriteLine("Enter a Mobile Number to validate : ");
                        string mobileNumber = Console.ReadLine();
                        result = user.ValidateMobileNumber(mobileNumber);
                        if (result)
                            Console.WriteLine("It is valid");
                        else
                            Console.WriteLine("It is not valid");
                        break;
                    case 5:
                        Console.WriteLine("Enter a Password to validate : ");
                        string password = Console.ReadLine();
                        result = user.ValidatePassword(password);
                        if (result)
                            Console.WriteLine("It is valid");
                        else
                            Console.WriteLine("It is not valid");
                        break;
                    case 6:
                        // Validating Sample Emails............
                        List<string> sampleEmailList = new List<string>()
                        {
                            "abc@yahoo.com",
                            "abc-100@yahoo.com",
                            "abc.100@yahoo.com",
                            "abc111@abc.com",
                            "abc-100@abc.net",
                            "abc.100@abc.com.au",
                            "abc@1.com",
                            "abc@gmail.com.com",
                            "abc+100@gmail.com"
                        };
                        foreach (string emails in sampleEmailList)
                        {
                            if (user.ValidateEmail(emails))
                            {
                                Console.WriteLine(" [ " + emails + " ]\t is Valid Email");
                            }
                            else
                            {
                                Console.WriteLine(" [ " + emails + " ]\t is Invalid Email");
                            }
                        }
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
