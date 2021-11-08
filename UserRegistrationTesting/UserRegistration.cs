﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationTesting
{
    public class UserRegistration
    {
        //Instance Variable
        public string message;

        //Parameterise Constructor
        public UserRegistration (string message)
        {
            this.message = message;
        }

        //create pattern 
        string pattern = "^91[ ][6-9]{1}[0-9]{9}$";

        //method for validating
        public string PatternChecking()
        {
            //used Regex predefined class
            Regex regex = new Regex(pattern);
            //used IsMatch Predefined Method
            if(regex.IsMatch (message))
            {
                return "valid";
            }
            else
            {
                return "invalid";
            }
        }
       
    }
}
