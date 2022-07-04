using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPasswordGenerator
{
    public class BuildPasswordProperties
    {
        private PasswordProperties p = new PasswordProperties();
        public BuildPasswordProperties Build()
        {

            p.IsIncludeLowerCase = false;
            p.IsIncludeNumber = false;
            p.IsIncludeSymbol = false;
            p.IsIncludeUpperCase = false;
            return this;
        }
        public PasswordProperties Finish()
        {
            String Reason = "";
            if (!IsValidRule(p, ref Reason))
            {
                throw new Exception("Rule is not valid :: Reason :: " + Reason);
            }
            return p;
        }
        public Boolean IsValidRule(PasswordProperties _Rule, ref String Reason)
        {
            Reason = "";

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
                Reason = " Password lenght is only " + _Rule.PasswordLength.ToString() + " please in crease password length";
                return false;
            }
            /*
            if (_Rule.IsIncludeSymbol)
            {
                if (SpecialCharactersChar == null || SpecialCharactersChar.Length == 0)
                {
                    Reason = " Special Character cannot be blank if you choose Include Special character.";
                    return false;
                }
            }
            */

            return true;

        }
        public BuildPasswordProperties UsingNonStandardSpecialCharacter(String nonStandard)
        {
            return this;
        }
        public BuildPasswordProperties Length(int pLength)
        {
            p.PasswordLength = pLength;
            return this;
        }

        public BuildPasswordProperties IncludeSymbol(Boolean pIsIncludeSymbol)
        {
            p.IsIncludeSymbol = pIsIncludeSymbol;
            return this;
        }
        public BuildPasswordProperties IncludeNumber(Boolean pIsIncludeNumber)
        {
            p.IsIncludeNumber = pIsIncludeNumber;
            return this;
        }

        public BuildPasswordProperties IncludeLowerCase(Boolean pIsIncludeLowerCase)
        {
            p.IsIncludeLowerCase = pIsIncludeLowerCase;
            return this;
        }

        public BuildPasswordProperties IncludeUpperCase(Boolean pIsIncludeUpperCase)
        {
            p.IsIncludeUpperCase = pIsIncludeUpperCase;
            return this;
        }

        public BuildPasswordProperties ExcludeSimilarCharacter(Boolean pIsExcludeSimilarCharacter)
        {
            p.IsExcludeAmbigousCharacter = pIsExcludeSimilarCharacter;
            return this;
        }

        public BuildPasswordProperties ExcludeAmbigousCharacter(Boolean pIsExcludeSimilarCharacter)
        {
            p.IsExcludeAmbigousCharacter = pIsExcludeSimilarCharacter;
            return this;
        }

        public BuildPasswordProperties ExcludeCompromisePassword(Boolean pIsExcludeCompromisePassword)
        {
            p.IsExcludeCompromisePassword = pIsExcludeCompromisePassword;
            return this;
        }
    }
}
