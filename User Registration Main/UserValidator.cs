using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Main
{
    public class UserValidator
    {
        public const String NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";

        public const String EMAIL_PATTERN = "^[a-z0-9]{1,}" +
                                            "([.|_|+|-]?[a-z0-9]+)?" +
                                            "[@]{1}" +
                                            "[a-z0-9]{1,}" +
                                            "[.]{1}[a-z]{2,4}" +
                                            "([.]{1}[a-z]{2,4})?$";

        public Boolean validateName(String name)
        {
            return Regex.IsMatch(name, NAME_PATTERN);
        }

        public Boolean validateEmail(String eMail)
        {
            return Regex.IsMatch(eMail, EMAIL_PATTERN);
        }
    }
}
