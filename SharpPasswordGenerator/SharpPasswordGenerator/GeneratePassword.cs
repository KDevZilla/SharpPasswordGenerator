using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SharpPasswordGenerator
{
    public class GeneratePassword
    {
        private IRandom _IR = null;
        private PasswordProperties _Rule = null;
        private HashSet<String> _HshCompromisedPassword = null;
        private enum CharTypeGenerate
        {
            Lower,
            Upper,
            Numeric,
            SpeicalCharacter
        }
        //private ILog _IL = null;
        public ILog IL { get; set; }
        private void Log(String message)
        {
            if (IL == null)
            {
                //throw new Exception("You have to configur ILog before using Log");
                //return;
                System.Diagnostics.Debug.WriteLine(message);
                return;
            }

            IL.Log(message);
        }

        public GeneratePassword(PasswordProperties Rule, IRandom IR)
        {
            Configure(Rule, IR, null, null);
        }

        private void Configure(PasswordProperties Rule, IRandom IR, String pSpecialCharactersChar, HashSet<String> pHshCompromisedPassword)
        {
            _Rule = Rule;
            _IR = IR;
            if (pSpecialCharactersChar != null)
            {
                _SpecialCharactersChar = pSpecialCharactersChar;
            }

            _HshCompromisedPassword = pHshCompromisedPassword;

            MethodResult<Boolean> result = IsValidRule(_Rule);
            if (!result.Result)
            {
                throw new Exception("Rule is not valid " + result.ErrorMessage);
            }
        }
        public GeneratePassword(PasswordProperties Rule, IRandom IR, String pSpecialCharactersChar)
        {
            Configure(Rule, IR, pSpecialCharactersChar, null);
        }

        public GeneratePassword(PasswordProperties Rule, IRandom IR, String pSpecialCharactersChar, HashSet<String> pHshCompromisedPassword)
        {
            Configure(Rule, IR, pSpecialCharactersChar, pHshCompromisedPassword);
        }
        public static Boolean IsMatchAllRule(PasswordProperties Rule)
        {
            return false;
        }
        const string Lowerchars = "abcdefghijklmnopqrstuvwxyz";
        const string Upperchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Numberchars = "0123456789";

        private string _SpecialCharactersChar = @"!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~";
        //https://owasp.org/www-community/password-special-characters


        public string SpecialCharactersChar
        {
            get
            {
                return _SpecialCharactersChar;
            }
        }

        private char GenerateLowerCase()
        {
            int iNextChar = _IR.Next(0, 25);
            return Lowerchars.Substring(iNextChar, 1).ToCharArray()[0];
        }
        private char GenerateUpperCase()
        {
            int iNextChar = _IR.Next(0, 25);
            return Upperchars.Substring(iNextChar, 1).ToCharArray()[0];
        }

        private char GenerateNumeric()
        {
            int iNextChar = _IR.Next(0, 9);
            return Numberchars.Substring(iNextChar, 1).ToCharArray()[0];
        }
        delegate char GenDelegate();

        private char GenerateSpecialCharacterChar()
        {
            if (SpecialCharactersChar == null || SpecialCharactersChar.Length == 0)
            {
                throw new Exception("Special Character cannot be null");
            }

            int iNextChar = _IR.Next(0, SpecialCharactersChar.Length - 1);
            return SpecialCharactersChar.Substring(iNextChar, 1).ToCharArray()[0];
        }
        private CharTypeGenerate GetCharType()
        {
            int iValue = _IR.Next(0, 4);
            return (CharTypeGenerate)iValue;
        }
        public MethodResult<Boolean> IsValidRule(PasswordProperties _Rule)
        {
            //Reason = "";
            MethodResult<Boolean> result = new MethodResult<Boolean>(false);
            int PasswordLengthRequie = 0;
            if (_Rule.IsIncludeNumber)
            {
                PasswordLengthRequie++;
            }
            if (_Rule.IsIncludeLowerCase)
            {
                PasswordLengthRequie++;
            }
            if (_Rule.IsIncludeUpperCase)
            {
                PasswordLengthRequie++;
            }
            if (_Rule.IsIncludeSymbol)
            {
                PasswordLengthRequie++;
            }


            if (PasswordLengthRequie > _Rule.PasswordLength)
            {

                result.ErrorMessage = " Password lenght is only " + _Rule.PasswordLength.ToString() + " please in crease password length";
                result.Result = false;
                return result;

            }
            if (_Rule.IsIncludeSymbol)
            {
                if (SpecialCharactersChar == null || SpecialCharactersChar.Length == 0)
                {

                    result.ErrorMessage = " Special Character cannot be blank if you choose Include Special character.";
                    result.Result = false;
                    return result;
                }
            }

            if (_Rule.IsExcludeCompromisePassword)
            {
                if (_HshCompromisedPassword == null)
                {

                    result.ErrorMessage = " Exclude compromised password option require to set lish of compromised password.";
                    result.Result = false;
                    return result;

                }
            }

            result.ErrorMessage = "";
            result.Result = true;
            return result;

        }

        public String SecureStringToString(SecureString value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }
        public MethodResult<Boolean> IsPasswordMatchRule(String password, PasswordProperties Rule)
        {
            string s = "";
            MethodResult<Boolean> Result = new MethodResult<Boolean>(true);

            PasswordProperties Properties = new PasswordProperties();
            /*
            if (Rule.PasswordLength != password.Length)
            {
                Reason = "Length";
                return false;
            }
            */
            Properties.PasswordLength = password.Length;

            foreach (char c in password)
            {
                if (Rule.IsIncludeLowerCase && !Properties.IsIncludeLowerCase)
                {
                    Properties.IsIncludeLowerCase = Lowerchars.IndexOf(c) > -1;
                }

                if (Rule.IsIncludeUpperCase && !Properties.IsIncludeUpperCase)
                {
                    Properties.IsIncludeUpperCase = Upperchars.IndexOf(c) > -1;
                }

                if (Rule.IsIncludeNumber && !Properties.IsIncludeNumber)
                {
                    Properties.IsIncludeNumber = Upperchars.IndexOf(c) > -1;
                }

                if (Rule.IsIncludeSymbol && !Properties.IsIncludeSymbol)
                {
                    Properties.IsIncludeSymbol = _SpecialCharactersChar.IndexOf(c) > -1;
                }


            }
            return Properties.IsMatch(Rule);
        }
        public SecureString GenerateWithTestData(String TestDataPassword)
        {

            var s = new SecureString();
            GenDelegate Genfunction = null;
            PasswordProperties PasswordGeneratedProperties = PasswordProperties.Build();
            String Reason = "";

            while (!PasswordGeneratedProperties.IsMatch(_Rule).Result == true)
            {
                CharTypeGenerate Chartype = GetCharType();

                switch (Chartype)
                {
                    case CharTypeGenerate.Lower:
                        if (_Rule.IsIncludeLowerCase)
                        {
                            Genfunction = GenerateLowerCase;
                            PasswordGeneratedProperties.IsIncludeLowerCase = true;
                        }
                        break;
                    case CharTypeGenerate.Upper:
                        if (_Rule.IsIncludeUpperCase)
                        {
                            Genfunction = GenerateUpperCase;
                            PasswordGeneratedProperties.IsIncludeUpperCase = true;
                        }
                        break;
                    case CharTypeGenerate.Numeric:
                        if (_Rule.IsIncludeLowerCase)
                        {
                            Genfunction = GenerateNumeric;
                            PasswordGeneratedProperties.IsIncludeNumber = true;
                        }
                        break;
                    case CharTypeGenerate.SpeicalCharacter:
                        Genfunction = GenerateSpecialCharacterChar;
                        PasswordGeneratedProperties.IsIncludeSymbol = true;
                        break;
                }

                s.AppendChar(Genfunction());

                if (s.Length > _Rule.PasswordLength)
                {
                    s = new SecureString();

                }
                PasswordGeneratedProperties.PasswordLength = s.Length;
            }
            return s;
        }
        int iCountGenerate = 0;
        public int CalculateEntrophy(PasswordProperties P)
        {
            try
            {
                int NumberofDigit = 0;
                if (P.IsIncludeLowerCase)
                {
                    NumberofDigit += 26;
                }

                if (P.IsIncludeUpperCase)
                {
                    NumberofDigit += 26;
                }
                if (P.IsIncludeNumber)
                {
                    NumberofDigit += 10;
                }
                if (P.IsIncludeSymbol)
                {
                    NumberofDigit += _SpecialCharactersChar.Length;
                }
                Double NumberofPossible = Math.Pow(NumberofDigit, P.PasswordLength);

                Double Entrophy = Math.Log(NumberofPossible, 2);

                return (int)Entrophy;


            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public String Genearte()
        {

            iCountGenerate = 0;
            //String Password = "";
            //var s = new SecureString();
            StringBuilder strB = new StringBuilder();

            //PasswordProperties PasswordGeneratedProperties = PasswordProperties.Build();
            PasswordProperties PasswordGeneratedProperties = new PasswordProperties();

            String Reason = "";
            while (!PasswordGeneratedProperties.IsMatch(_Rule).Result)
            {
                iCountGenerate++;
                if (iCountGenerate >= 1000000)
                {
                    throw new Exception(@"Thre muse be something wrong with your Random number generator.
                    we have run it 1000000 times but still cannot generate a password that match the requirement");
                }
                CharTypeGenerate Chartype = GetCharType();
                GenDelegate Genfunction = null;
                switch (Chartype)
                {
                    case CharTypeGenerate.Lower:
                        if (_Rule.IsIncludeLowerCase)
                        {
                            Genfunction = GenerateLowerCase;
                            PasswordGeneratedProperties.IsIncludeLowerCase = true;
                        }
                        break;
                    case CharTypeGenerate.Upper:
                        if (_Rule.IsIncludeUpperCase)
                        {
                            Genfunction = GenerateUpperCase;
                            PasswordGeneratedProperties.IsIncludeUpperCase = true;
                        }
                        break;
                    case CharTypeGenerate.Numeric:
                        if (_Rule.IsIncludeNumber)
                        {
                            Genfunction = GenerateNumeric;
                            PasswordGeneratedProperties.IsIncludeNumber = true;
                        }
                        break;
                    case CharTypeGenerate.SpeicalCharacter:
                        if (_Rule.IsIncludeSymbol)
                        {
                            Genfunction = GenerateSpecialCharacterChar;
                            PasswordGeneratedProperties.IsIncludeSymbol = true;
                        }
                        break;
                }
                if (Genfunction == null)
                {
                    continue;
                }
                //s.AppendChar(Genfunction());
                strB.Append(Genfunction());
                if (strB.ToString().Length == _Rule.PasswordLength)
                {
                    if (_Rule.IsExcludeCompromisePassword)
                    {
                        if (_HshCompromisedPassword.Contains(strB.ToString()))
                        {
                            PasswordGeneratedProperties.IsExcludeCompromisePassword = false;
                        }
                        else
                        {
                            PasswordGeneratedProperties.IsExcludeCompromisePassword = true;
                        }
                    }
                }
                if (strB.ToString().Length > _Rule.PasswordLength)
                {
                    //s = new SecureString();
                    strB = new StringBuilder();
                    PasswordGeneratedProperties = new PasswordProperties();
                }
                PasswordGeneratedProperties.PasswordLength = strB.ToString().Length;
            }
            return strB.ToString();
        }
    }
}
