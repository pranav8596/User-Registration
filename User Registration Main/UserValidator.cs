using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Main
{
    public class UserValidator
    {
        public const String NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";

        public Boolean validateName(String name)
        {
            return Regex.IsMatch(name, NAME_PATTERN);
        }
    }
}
