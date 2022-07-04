using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPasswordGenerator
{
    public class LookUp
    {
        private static HashSet<String> _CompromisedPasswordHsh = null;
        public static HashSet<String> CompromisedPasswordHsh
        {
            get
            {
                if (_CompromisedPasswordHsh == null)
                {
                    LoadCompromisedPassword();
                }
                return _CompromisedPasswordHsh;
            }
        }

        private static void LoadCompromisedPassword()
        {
            /*
            Author:SkyZyx
            Link:https://github.com/skyzyx/bad-passwords
            */
            System.IO.StreamReader SR = new System.IO.StreamReader(Utility.CurrentPath + @"\CompromisedPassword.txt");
            String strlistofPassword = SR.ReadToEnd();
            SR.Close();
            string[] arrPwd = strlistofPassword.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            _CompromisedPasswordHsh = new HashSet<string>();
            foreach (String CompromisedPassword in arrPwd)
            {
                _CompromisedPasswordHsh.Add(CompromisedPassword.Trim());
            }
        }
    }
}
