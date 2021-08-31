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
        public bool ValidateFirstName(string firstName) => (Regex.IsMatch(firstName, namePattern));
        public bool ValidateLastName(string lastName) => (Regex.IsMatch(lastName, namePattern));

        //Pattern for validating the email
        string emailPattern = "^[A-Za-z0-9]+([._+-][A-Za-z0-9]+)*@[0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public bool ValidateEmail(string email) => (Regex.IsMatch(email, emailPattern));

        //Pattern for validating the Mobile Number
        string numberPattern = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        public bool ValidateMobileNumber(string mobileNumber) => (Regex.IsMatch(mobileNumber, numberPattern));

        //Pattern for validating the password
        string passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=[\\w]*[\\W][\\w]*$)[A-Za-z1-9.@!#$&%^*]{8,}";
        public bool ValidatePassword(string password) => (Regex.IsMatch(password, passwordPattern));
    }
}