using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Project.ValidationFarmework.helper
{
    public class ValidationHelper
    {
        //email validation plain version
        public static bool IsValidEmail(string email)
        {
            var trimmedEmail=email.Trim();
            if (email.Length == 0)
            {
                return false;
            }
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr=new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        //email validation using data-anotation
        public bool IsValidEmailVersion2(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }


        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"(84|0[3|5|7|8|9])+([0-9]{8})\b");

        }
    }
}
