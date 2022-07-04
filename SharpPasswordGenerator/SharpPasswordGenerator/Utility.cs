using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpPasswordGenerator
{
    public class Utility
    {





        public static Boolean IsNumeric(String str)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static String CurrentPath { get { return System.AppDomain.CurrentDomain.BaseDirectory; } }
        public static Boolean IsAlphaNumeric(String str)
        {
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (!r.IsMatch(str))
            {
                return false;
            }
            return true;
        }
    }
}
