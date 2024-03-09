using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectA_199.validations
{
    public static class validation
    {
        public static bool email(string email)
        {
            email = email.Trim();
            if (!(email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase)) && email.Length > 30)
            {
                return false;
            }
            return true;
        }
        public static bool contact(string contact) 
        {
            if(contact.Length != 11 && !contact.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }
        public static bool name(string name)
        {
            return name.Length <= 100;
        }
        public static bool DOB(DateTime dob)
        {
            DateTime dtNow = DateTime.Now;
            DateTime dt_18 = dob.AddYears(18);
            if(dtNow < dt_18)
            {
                return false;
            }
            return true;
        }
    }
    

}
