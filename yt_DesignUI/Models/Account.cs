﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
    public class Account
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public Account(string name, string surname, string email, string password)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
        }

        public void ChangePassword(string newPassword)
        {
            Password = newPassword;
        }

        public bool IsPasswordValid(string password)
        {
            return password.Length >= 8;
        }

        public string GetAccountInfo()
        {
            return $"Name: {Name}, Surname: {Surname}, Email: {Email}";
        }

        public bool CheckPassword(string inputPassword)
        {
            return Password == inputPassword;
        }

        public static bool operator ==(Account a, Account b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.Name == b.Name && a.Surname == b.Surname && a.Email == b.Email && a.Password == b.Password;
        }

        public static bool operator !=(Account a, Account b)
        {
            return !(a == b);
        }

    }
}
