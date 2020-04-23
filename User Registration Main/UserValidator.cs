using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Main
{
    public class UserValidator
    {
        //Pattern for First and Last name
        public const String NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";

        //Pattern for Email address
        public const String EMAIL_PATTERN = "^[a-z0-9]{1,}" +
                                            "([.|_|+|-]?[a-z0-9]+)?" +
                                            "[@]{1}" +
                                            "[a-z0-9]{1,}" +
                                            "[.]{1}[a-z]{2,4}" +
                                            "([.]{1}[a-z]{2,4})?$";

        //Pattern for Mobile Number
        public const String MOBILE_PATTERN = "^[0-9]{1,3}" +
                                             "[ ]{1}" +
                                             "[0-9]{10}$";

        // Pattern for Password Rule 1: Minimum 8 chracters
        public String PASSWORD_PATTERN1 = "^[a-z]{8,}$";

        // Pattern for Password Rule 2: At least 1 upper case character
        public String PASSWORD_PATTERN2 = "^(?=.*[A-Z])." +
                                          "[A-Za-z]{7,}$";

        // Pattern for Password Rule 3: Atleast 1 numeric number
        public String PASSWORD_PATTERN3 = "^(?=.*[A-Z])" +
                                          "(?=.*[0-9])" +
                                          "[A-Za-z0-9]{8,}$";

        // Pattern for Password Rule 4: Exact 1 special character
        public String PASSWORD_PATTERN4 = "^(?=[^@#$%!&]*[@#$%!&][^@#$%!&]*$)" +
                                           "(?=.*[0-9])" +
                                           "(?=.*[A-Z])" +
                                           "[A-Za-z0-9@#$%!&]{8,}$";

        //To validate User's Fisrt and Last name
        public Boolean validateName(String name)
        {
            return Regex.IsMatch(name, NAME_PATTERN);
        }

        //To validate User's Email address
        public Boolean validateEmail(String eMail)
        {
            return Regex.IsMatch(eMail, EMAIL_PATTERN);
        }

        //To validate User's Mobile number
        public Boolean validateMobileNumber(String mobNumber)
        {
            return Regex.IsMatch(mobNumber, MOBILE_PATTERN);
        }

        //To validate User's Passowrd
        public Boolean validatePassword(String password, String PASSWORD_PATTERN)        
        {
            String passwordPattern = PASSWORD_PATTERN;
            return Regex.IsMatch(password, passwordPattern);
        }
    }
}
