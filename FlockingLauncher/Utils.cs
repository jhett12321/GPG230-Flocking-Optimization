using System;
using System.Text.RegularExpressions;

class Utils
{


    public static bool ValidatePort(string port)
    {
        if (string.IsNullOrEmpty(port))
        {
            return false;
        }


        Regex numeric = new Regex(@"^[0-9]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        if (numeric.IsMatch(port))
        {
            try
            {
                if (Convert.ToInt32(port) < 65536)
                {
                    return true;
                }
            }
            catch (OverflowException)
            {
            }
        }

        return false;
    }
}
