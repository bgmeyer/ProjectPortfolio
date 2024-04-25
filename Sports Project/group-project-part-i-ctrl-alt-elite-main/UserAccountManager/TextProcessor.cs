using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountManager
{
    public class TextProcessor
    {

       public bool isEmpty(string txt)
        {
            if (string.IsNullOrEmpty(txt))
            {
               
                return true;
            }
            
             return false;
        }
        public bool isEmpty(string fName, string lName, string userName, string fPassword, string sPassword)
        {
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(fPassword) || string.IsNullOrEmpty(sPassword))
            {

                return true;
            }

            return false;
        }
        public string removeWhiteSpace(string txt)
        {
            string trimmedTxt = txt.Trim();
            return trimmedTxt;
        }


        public bool passwordValidation(string password)
        {
            //check password is 6 characters long 
            if(password.Length < 6)
            {
                return false;
            }

            //check to see if there is special characters 
            bool specialCharacters = false;
            //loop through each char in password 
            foreach (char c in password)
            {
                if(char.IsPunctuation(c))
                {
                    //assign true if has punctuation 
                    specialCharacters = true;
                    //leave loop 
                    break;
                }
            }
            // if true 
            if (!specialCharacters)
            {
                return false;
            }

            //check to see if has digit 
            bool hasDigit = false;
            //loop through each char in password 
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    //assign true if has digit 
                    hasDigit = true;
                    //leave loop 
                    break;
                }
            }
            if (!hasDigit)
            { 
                return false;
            }

            // Check if password contains  uppercase letter
            bool hasUpperCase = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    //assign true if has uppercase
                    hasUpperCase = true;
                    //leave loop
                    break;
                }
            }
            if (!hasUpperCase)
            {
                return false;
            }

            return true;

        }
    }
}
