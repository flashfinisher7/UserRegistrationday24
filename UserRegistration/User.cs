using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class User
    {
        //Pattern for validating the name
        string namePattern = "^[A-Z]{1}[A-Za-z]{2,}$";
        /// <summary>
        ///  Validating the First Name
        /// </summary>
        public bool ValidateFirstName(string firstName)
        {
            Regex regex = new Regex(namePattern);
            bool result = regex.IsMatch(firstName);
            return result;
        }
        /// <summary>
        ///  Validating the Last Name
        /// </summary>
        public bool ValidateLastName(string lastName)
        {
            Regex regex = new Regex(namePattern);
            bool result = regex.IsMatch(lastName);
            return result;
        }
        //Pattern for validating the email
        string emailPattern = "^[A-Za-z0-9]+([._+-][A-Za-z0-9]+)*@[0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        /// <summary>
        ///   Validating the Email
        /// </summary>
        public bool ValidateEmail(string email)
        {
            Regex regex = new Regex(emailPattern);
            bool result = regex.IsMatch(email);
            return result;
        }
        //Pattern for validating the Mobile Number
        string numberPattern = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        /// <summary>
        ///   Validating the Mobile Number
        /// </summary>
        public bool ValidateMobileNumber(string mobileNumber)
        {
            Regex regex = new Regex(numberPattern);
            bool result = regex.IsMatch(mobileNumber);
            return result;
        }
        //Pattern for validating the password
        string passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=[\\w]*[\\W][\\w]*$)[A-Za-z1-9.@!#$&%^*]{8,}";
        /// <summary>
        ///   Validating the Password
        /// </summary>
        public bool ValidatePassword(string password)
        {
            Regex regex = new Regex(passwordPattern);
            bool result = regex.IsMatch(password);
            return result;
        }
    }
}