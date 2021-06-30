using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.Utilities
{
    public class ValidityUtilities
    {
        // Method that checks the validity of an email address
        // Param: string (email address to be validated)
        // Returns: bool (true if valid / false if invalid)
        public static bool IsValidEmail(string email)
        {
            email = email.Trim();

            if (String.IsNullOrEmpty(email))
            {
                return false;
            }
            else
            {
                return new System.ComponentModel.DataAnnotations.EmailAddressAttribute().IsValid(email);
            }
        }
    }
}
