﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            // Create a username for the person
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1) }{ user.LastName }");
        }
    }
}
