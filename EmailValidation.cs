using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Utilities.Validations
{
    public static class EmailValidation
    {
        /// <summary>
        /// Email Seperatd by Comma Or Semi-colon
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string IsValidMultipleEmail(string value)
        {
            //Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            //"
            Regex regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            string wrongEmailAddress = string.Empty;
            string[] emails = value.Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            

            return emails.Where(email => !regex.IsMatch(email)).Aggregate(wrongEmailAddress, (current, email) => current + (email + ","));
        }
    }
}
