using System;
using System.Text.RegularExpressions;

namespace Tickets.Models
{
    public class Validation
    {
        public Validation()
        {
            
        }
        
        public bool IsInt(object obj)
        {
            return obj is int;
        }
        
        public bool IsString(object obj)
        {
            if (obj is string str)
            {
                return str.Length > 2;
            }
            return false;
        }
        
        public bool IsValidPassword(string password)
        {
            if (password == null)
            {
                return false;
            }
            string pattern = @"^(?=.*[a-zA-Z])(?=.*\d).+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }
        
        public bool IsValidEmail(string email)
        {
            if (email == null)
            {
                return false;
            }
            
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}